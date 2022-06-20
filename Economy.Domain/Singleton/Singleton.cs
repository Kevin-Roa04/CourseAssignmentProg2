using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.Singleton
{
    public class Singleton
    {
        private static Singleton instance = null;
        public int Index;
        public decimal ValueFunction;
        public double ValueTask;
        public int MaxRow;
        public int MaxColumn;
        public int MinRow;
        public int MinColumn;
        public List<double> Entry = new List<double>();
        public List<double> Exit = new List<double>();
        public List<double> ValueFunctionList = new List<double>();
        public bool Selection;
        public bool Type;

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
