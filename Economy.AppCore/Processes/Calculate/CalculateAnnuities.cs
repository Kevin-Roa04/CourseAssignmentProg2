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
    public class CalculateAnnuities : ICalculateServices<Annuity>

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
        public decimal Annuity(Annuity t)
        {
            if (t.Type == TypeAnnuities.Anticipated.ToString())
            {
                return AnticipatedAnnuity(t);
            }
            else if (t.Type == TypeAnnuities.Deferred.ToString())
            {
                return DeferredAnnuity(t);
            }
            else if (t.Type == TypeAnnuities.Ordinary.ToString())
            {
                return OrdinaryAnnuity(t);
            }
            return 0;
        }

        #region Annuity

        private decimal OrdinaryAnnuity(Annuity t)
        {
            if (t.Present == null)
            {
                return AnnuityFromOrdinaryFuture(t);
            }
            else
            {
                return AnnuityFromOrdinaryPresent(t);
            }
        }
        private decimal AnnuityFromOrdinaryPresent(Annuity t)
        {
            double p = (double)t.Present;
            double i = (double)t.Rate;
            double n = t.End;
            double Ri = Math.Pow((double)(1 + i), n);

            decimal Annuity = (decimal)(p * ((i * Ri) / (Ri - 1)));
            return Annuity;
        }

        private decimal AnnuityFromOrdinaryFuture(Annuity t)
        {
            double f = (double)t.Future;
            double i = (double)t.Rate;
            double n = t.End;
            double Ri = Math.Pow((double)(1 + i), n);

            decimal Annuity = (decimal)(f * (i / (Ri - 1)));
            return Annuity;
        }

        private decimal AnticipatedAnnuity(Annuity t)
        {
            if (t.Present == null)
            {
                return AnnuityFromAnticipatedFuture(t);
            }
            else
            {
                return AnnuityFromAnticipatedPresent(t);
            }

        }

        private decimal AnnuityFromAnticipatedFuture(Annuity t)
        {
            double f = (double)t.Future;
            double i = (double)t.Rate;
            double n = t.End;
            double Ri = Math.Pow((double)(1 + i), n + 1) - 1;
            double denom = (Ri / i) - 1;

            decimal Annuity = (decimal)(f / denom);
            return Annuity;
        }

        private decimal AnnuityFromAnticipatedPresent(Annuity t)
        {
            double p = (double)t.Present;
            double i = (double)t.Rate;
            double n = t.End;
            double Ri = (double)(1 - Math.Pow((double)(1 + i), -(n - 1)));
            double denom = 1 + (Ri / i);

            decimal Annuity = (decimal)(p / denom);
            return Annuity;
        }

        private decimal DeferredAnnuity(Annuity t)
        {
            if (t.Present == null)
            {
                return AnnuityFromDeferredFuture(t);
            }
            else
            {
                return AnnuityFromDeferredPresent(t);
            }

        }
        private decimal AnnuityFromDeferredPresent(Annuity t)
        {
            throw new ArgumentException();
        }

        private decimal AnnuityFromDeferredFuture(Annuity t)
        {
            throw new ArgumentException();
        }
        #endregion
        #region Present
        private decimal OrdinaryPresent(Annuity t)
        {
            decimal decimalPercent = t.Rate / 100;
            decimal Numerator = (decimal)Math.Pow((double)(1 + decimalPercent), t.End) - 1;
            decimal Denominator = (decimal)((double)decimalPercent * Math.Pow((double)(1 + decimalPercent), t.End));
            decimal Present = (decimal)(t.Payment * (Numerator / Denominator));
            Present = Math.Round(Present, 2);
            return Present;
        }
        private decimal AnticipatedPresent(Annuity t)
        {
            decimal decimalPercent = t.Rate / 100;
            decimal Numerator = (decimal)Math.Pow((double)(1 + decimalPercent), (t.End)) - 1;
            decimal Denominator = (decimal)(decimal)((double)decimalPercent * Math.Pow((double)(1 + decimalPercent), (t.End)));
            decimal Present = (decimal)(t.Payment + (t.Payment * (Numerator / Denominator)));
            Present = Math.Round(Present, 2);
            return Present;
        }
        private decimal DeferredPresent(Annuity t)
        {
            decimal decimalPercent = t.Rate / 100;
            decimal Numerator = (decimal)Math.Pow((double)(1 + decimalPercent), (t.End - (t.Initial - 1))) - 1;
            decimal Denominator = (decimal)((double)decimalPercent * Math.Pow((double)(1 + decimalPercent), t.End));
            decimal Present = (decimal)(t.Payment * (Numerator / Denominator));
            Present = Math.Round(Present, 2);
            return Present;
        }

        #endregion
        #region Future

     
        private decimal OrdinaryFuture(Annuity t)
        {
            decimal decimalPercent = t.Rate / 100;
            decimal Numerator = (decimal)Math.Pow((double)(1 + decimalPercent), t.End) - 1;
            decimal Future = (decimal)t.Payment * (Numerator / decimalPercent)*(decimal)(Math.Pow((double)(1+decimalPercent),(t.TotalPeriod-t.End)));
            return Future;
        }
        private decimal AnticipatedFuture(Annuity t)
        {
            decimal decimalPercent = t.Rate / 100;
            decimal Numerator = (decimal)Math.Pow((double)(1 + decimalPercent), (t.End)) - 1;
            decimal Denominator = (decimal)((double)decimalPercent * Math.Pow((double)(1 + decimalPercent), (t.End)));
            decimal Future = ((decimal)(t.Payment + ((decimal)t.Payment * (Numerator / Denominator)))) * (decimal)Math.Pow((double)(1 + decimalPercent),(t.TotalPeriod- t.End));
            return Future;
        }
        private decimal DeferredFuture(Annuity t)
        {
            decimal decimalPercent = t.Rate / 100;
            decimal Numerator = (decimal)Math.Pow((double)(1 + decimalPercent), (t.End - (t.Initial - 1))) - 1;
            decimal Future = (decimal)t.Payment * (Numerator / decimalPercent)*(decimal)(Math.Pow((double)(1 + decimalPercent), t.TotalPeriod-t.End));
            return Future;
        }
        #endregion
    }
}
