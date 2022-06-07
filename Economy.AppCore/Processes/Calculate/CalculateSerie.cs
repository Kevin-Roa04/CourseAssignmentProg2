using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.Processes.Calculate
{
    public class CalculateSerie : ICalculateServices<Serie>
    {
        public decimal Future(Serie t)
        {
           return GeneralFuture(t);
        }

        public decimal Present(Serie t)
        {
            if (t.Type == TypeSeries.Arithmetic.ToString())
            {
                return ArithmeticPresent(t);
            }

            return GeometricPresent(t);

        }


        #region Present
        private decimal ArithmeticPresent(Serie s)
        {
            // Arithmetic Present= Ordinary present(+-)Gradient present

            // Ordinary Present.s
            decimal decimalPercent = s.Rate / 100;
            decimal Numerator = (decimal)Math.Pow((double)(1 + decimalPercent), (s.End-s.Initial)+1) - 1;
            decimal Denominator = (decimal)((double)decimalPercent * Math.Pow((double)(1 + decimalPercent), (s.End-s.Initial)+1));
            decimal Present = (decimal)(s.DownPayment * (Numerator / Denominator));

            // Gradient present.
            decimal FirstNumerator = (decimal)(Math.Pow((double)(1 + decimalPercent), ((s.End-s.Initial)+1)) - 1);
            decimal FirstDenominator = (decimal)(decimalPercent * (decimal)(Math.Pow((double)(1 + decimalPercent), (s.End-s.Initial)+1)));
            decimal SecondFraction=(decimal)((-((s.End-s.Initial)+1))/(Math.Pow((double)(1+decimalPercent),(s.End-s.Initial)+1)));
            decimal FirstEcuation = (FirstNumerator / FirstDenominator) + (SecondFraction);
            decimal GradientPresent = (s.Quantity / decimalPercent) * FirstEcuation;
            if (s.Initial == 1)
            {
                return s.Incremental == true ? Present + GradientPresent : Present - GradientPresent;
            }
            decimal PresentCompound = (decimal)Math.Pow((double)(1+decimalPercent), -(s.Initial - 1));
            return s.Incremental == true ? (Present + GradientPresent) * (PresentCompound) : (Present - GradientPresent) * (PresentCompound);
        }
        private decimal GeometricPresent(Serie s)
        {
            decimal decimalPercent = s.Rate / 100;
            decimal decimalPresentQuantity = s.Quantity / 100;
            if (s.Quantity == s.Rate)
            {

                return (decimal)(s.DownPayment * (s.End / (1 + decimalPercent))) * (decimal)Math.Pow((double)(1 + decimalPercent), -(s.Initial - 1)); ;
                
            }
            
            decimal Numerator = (decimal)((Math.Pow((double)((1 + decimalPresentQuantity) / (1 + decimalPercent)), ((s.End-s.Initial)+1))) - 1);
            decimal Denominator = (decimal)(decimalPresentQuantity - decimalPercent);
            decimal Present = ((decimal)(s.DownPayment * (Numerator / Denominator)));
            decimal TotalPresent=Present * (decimal)Math.Pow((double)(1 + decimalPercent), -(s.Initial - 1));
            return TotalPresent;
        }
        #endregion

        #region Future
        
        private decimal GeneralFuture(Serie s)
        {
            decimal decimalPercent = s.Rate / 100;
            return (decimal)(s.Present * (decimal)(Math.Pow((double)(1 + decimalPercent), s.TotalPeriod)));
        }
        #endregion
    }
}
