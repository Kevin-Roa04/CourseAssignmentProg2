using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.Processes.Calculate
{
    public class CalculateInterest : IInterestServices<Interest>
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
            decimal decimalPercent = i.Rate / 100;
            decimal Present = (decimal)i.Future * (decimal)Math.Pow((double)(1 + decimalPercent), (-i.End));
            return Present;
        }


        #endregion

        #region Future
        private decimal InterestFuture(Interest i)
        {
            decimal decimalPercent = i.Rate / 100;
            decimal Future = (decimal)i.Present * (decimal)Math.Pow((double)(1 + decimalPercent), i.End);
            return Future;
        }
        #endregion
    }
}
