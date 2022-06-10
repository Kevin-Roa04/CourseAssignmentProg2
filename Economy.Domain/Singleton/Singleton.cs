using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.Singleton
{
    public class Singleton
    {
        public List<double> vs = new List<double>();
        private static Singleton instance = null;
        public int Index;
        public decimal ValueFunction;
        public double ValueTask;
        public int Row;
        public int Column;

        protected Singleton()
        {

        }
        public static Singleton instance1
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
