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
            if (t.Type == TypeSeries.Arithmetic.ToString())
            {
                return ArithmeticFuture(t);
            }

            return GeometricFuture(t);
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
            // Arithmetic Present= Ordinary present(+-)Gradient present.

            // Ordinary Present.s
            decimal decimalPercent = s.Rate / 100;
            decimal Numerator = (decimal)Math.Pow((double)(1 + decimalPercent), s.End) - 1;
            decimal Denominator = (decimal)((double)decimalPercent * Math.Pow((double)(1 + decimalPercent), s.End));
            decimal Present = (decimal)(s.DownPayment * (Numerator / Denominator));

            // Gradient present.
            decimal GradientNumerator = (decimal)(-s.Quantity * (decimal)(Math.Pow((double)(1 + s.Rate), s.End))) + s.Quantity + (s.End + s.Quantity + s.Rate);
            decimal GradientDenominator = (decimal)(Math.Pow((double)(1 + s.Rate), s.End));
            decimal GradientPresent = GradientNumerator / GradientDenominator;

            return s.Incremental == true ? Present + GradientPresent : Present - GradientPresent;
        }
        private decimal GeometricPresent(Serie s)
        {
            decimal decimalPercent = s.Rate / 100;
            decimal decimalPresentQuantity = s.Quantity / 100;
            if (s.Quantity == s.Rate)
            {

                return (decimal)(s.DownPayment * (s.End / (1 + decimalPercent)));
            }

            decimal Numerator = (decimal)((Math.Pow((double)((1 + decimalPresentQuantity) / (1 + decimalPercent)), s.End)) - 1);
            decimal Denominator = (decimal)(decimalPresentQuantity - decimalPercent);
            decimal Present = (decimal)(s.DownPayment * (Numerator / Denominator));
            return Present;
        }
        #endregion

        #region Future
        private decimal GeometricFuture(Serie s)
        {
            decimal decimalPercent = s.Rate / 100;
            if (s.Rate == s.Quantity)
            {
                return (decimal)(s.DownPayment * s.End * (decimal)(Math.Pow((double)(1 + decimalPercent), s.End - 1)));
            }
            decimal decimalQuantity = s.Quantity / 100;
            decimal Numerator = (decimal)(Math.Pow((double)(1 + decimalQuantity), s.End)) - (decimal)(Math.Pow((double)(1 + decimalPercent), s.End));
            decimal Denominator = decimalQuantity - decimalPercent;

            return (decimal)(s.DownPayment * (Numerator / Denominator));
        }
        private decimal ArithmeticFuture(Serie s)
        {
            decimal decimalPercent = s.Rate / 100;

            // Ordinary Future

            decimal Numerator = (decimal)Math.Pow((double)(1 + decimalPercent), s.End) - 1;
            decimal OrdinaryFuture = (decimal)s.DownPayment * (Numerator / decimalPercent);

            // Gradient Future
            decimal FirstFormula = (decimal)((Math.Pow((double)(1 + decimalPercent), s.End) - 1)) / (decimal)Math.Pow((double)decimalPercent, 2);
            decimal SecondFormula = (decimal)(s.End / decimalPercent);
            decimal GradientFuture = (decimal)s.Quantity * (FirstFormula - SecondFormula);

            return s.Incremental == true ? OrdinaryFuture + GradientFuture : OrdinaryFuture - GradientFuture;


        }

        #endregion
    }
}
