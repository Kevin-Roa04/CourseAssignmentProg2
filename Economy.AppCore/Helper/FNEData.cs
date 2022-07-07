using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.Helper
{
    public class FNEData
    {
        public static List<decimal> Profit { get; set; }
        public static List<decimal> Cost { get; set; }
        public static List<decimal> Interest { get; set; }
        public static decimal Prestamo { get; set; }
        public static List<decimal> Amortization { get; set; }
        public static decimal Inversion { get; set; }
        public static List<decimal> Depreciacion { get; set; }
        public static decimal ValorDeRescate { get; set; }

        public static void resetValues()
        {
            Profit = null;
            Cost = null;
            Interest = null;
            Prestamo = new decimal();
            Amortization = null;
            Inversion = new decimal();
            Depreciacion = null;
            ValorDeRescate = new decimal();
        }

    }
}
