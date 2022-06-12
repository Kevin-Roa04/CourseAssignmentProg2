using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.Processes.Calculate
{
    public class CalculateInterest : ICalculateServices<Interest>
    {

        public decimal Future(Interest t)
        {
            return InterestFuture(t);
        }

        public decimal Present(Interest t)
        {
            return InterestPresent(t);
        }


        #region Present
        private decimal InterestPresent(Interest i)
        {
            decimal future = i.Payment;
            
            decimal decimalPercent = i.Rate / 100;
            decimal Present = (decimal)future * (decimal)Math.Pow((double)(1 + decimalPercent), (-i.End));
            Present = Math.Round(Present, 2);
            return Present;
        }


        #endregion

        #region Future
        private decimal InterestFuture(Interest i)
        {
            decimal present = i.Payment;
            decimal decimalPercent = i.Rate / 100;
            decimal Future = (decimal)present * (decimal)Math.Pow((double)(1 + decimalPercent), (i.TotalPeriod-i.Initial));
            return Future;
        }
        #endregion
    }
}
