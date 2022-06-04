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
    public class CalculateAnnuities : IInterestServices<Annuity>

    {
        public decimal Future(Annuity t)
        {
            if (t.Type == TypeAnnuities.Anticipated.ToString())
            {
                return AnticipatedFuture(t);
            }
            else if (t.Type == TypeAnnuities.Deferred.ToString())
            {
                return DeferredFuture(t);
            }
            else if (t.Type == TypeAnnuities.Ordinary.ToString())
            {
                return OrdinaryFuture(t);
            }
            return 0;
        }

        public decimal Present(Annuity t)
        {
            if (t.Type == TypeAnnuities.Anticipated.ToString())
            {
                return AnticipatedPresent(t);
            }
            else if (t.Type == TypeAnnuities.Deferred.ToString())
            {
                return DeferredPresent(t);
            }
            else if (t.Type == TypeAnnuities.Ordinary.ToString())
            {
                return OrdinaryPresent(t);
            }
            return 0;
        }

        #region Present
        private decimal OrdinaryPresent(Annuity t)
        {
            decimal decimalPercent = t.Rate / 100;
            decimal Numerator = (decimal)Math.Pow((double)(1 + decimalPercent), t.End) - 1;
            decimal Denominator = (decimal)((double)decimalPercent * Math.Pow((double)(1 + decimalPercent), t.End));
            decimal Present = (decimal)(t.Payment * (Numerator / Denominator));
            return Present;
        }
        private decimal AnticipatedPresent(Annuity t)
        {
            decimal decimalPercent = t.Rate / 100;
            decimal Numerator = (decimal)Math.Pow((double)(1 + decimalPercent), (t.End - 1)) - 1;
            decimal Denominator = (decimal)(decimal)((double)decimalPercent * Math.Pow((double)(1 + decimalPercent), (t.End - 1)));
            decimal Present = (decimal)(t.Payment + (t.Payment * (Numerator / Denominator)));
            return Present;
        }
        private decimal DeferredPresent(Annuity t)
        {
            decimal decimalPercent = t.Rate / 100;
            decimal Numerator = (decimal)Math.Pow((double)(1 + decimalPercent), (t.End - (t.Initial - 1))) - 1;
            decimal Denominator = (decimal)((double)decimalPercent * Math.Pow((double)(1 + decimalPercent), t.End));
            decimal Present = (decimal)(t.Payment * (Numerator / Denominator));
            return Present;
        }

        #endregion
        #region Future
        private decimal OrdinaryFuture(Annuity t)
        {
            decimal decimalPercent = t.Rate / 100;
            decimal Numerator = (decimal)Math.Pow((double)(1 + decimalPercent), t.End) - 1;
            decimal Future = (decimal)t.Payment * (Numerator / decimalPercent);
            return Future;
        }
        private decimal AnticipatedFuture(Annuity t)
        {
            decimal decimalPercent = t.Rate / 100;
            decimal Numerator = (decimal)Math.Pow((double)(1 + decimalPercent), (t.End - 1)) - 1;
            decimal Denominator = (decimal)((double)decimalPercent * Math.Pow((double)(1 + decimalPercent), (t.End - 1)));
            decimal Future = ((decimal)(t.Payment + ((decimal)t.Payment * (Numerator / Denominator)))) * (decimal)Math.Pow((double)(1 + decimalPercent), t.End);
            return Future;
        }
        private decimal DeferredFuture(Annuity t)
        {
            decimal decimalPercent = t.Rate / 100;
            decimal Numerator = (decimal)Math.Pow((double)(1 + decimalPercent), (t.End - (t.Initial - 1))) - 1;
            decimal Future = (decimal)t.Payment + (Numerator / decimalPercent);
            return Future;
        }
        #endregion
    }
}
