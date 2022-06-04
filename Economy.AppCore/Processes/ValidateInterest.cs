using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.Processes
{
    public static class ValidateInterest

    {
        public static bool Validar<T>(List<object> lists, T t)
        {
            if (lists.Where(x =>(string) x.GetType().GetProperty("FlowType").GetValue(x) == (string)t.GetType().GetProperty("FlowType").GetValue(t) 
            &&(int) x.GetType().GetProperty("Initial").GetValue(x) == (int)t.GetType().GetProperty("Initial").GetValue(t)
            && (int)t.GetType().GetProperty("End").GetValue(t) > (int)x.GetType().GetProperty("Emd").GetValue(x)).ToList().Count > 0)
            {
                return false;
            }
            else if (lists.Where(x => (string)x.GetType().GetProperty("FlowType").GetValue(x) == (string)t.GetType().GetProperty("FlowType").GetValue(t) 
            && (int)x.GetType().GetProperty("Initial").GetValue(x) <= (int)t.GetType().GetProperty("Initial").GetValue(t)
            && (int)t.GetType().GetProperty("End").GetValue(t) <= (int)x.GetType().GetProperty("End").GetValue(x)).ToList().Count > 0)
            {
                return false;
            }
            else if (lists.Where(x => (string)x.GetType().GetProperty("FlowType").GetValue(x) == (string)t.GetType().GetProperty("FlowType").GetValue(t) 
            &&(int)x.GetType().GetProperty("Initial").GetValue(x) < (int)t.GetType().GetProperty("Initial").GetValue(t)
            && (int)x.GetType().GetProperty("End").GetValue(x) > (int)t.GetType().GetProperty("Initial").GetValue(t)).ToList().Count > 0)
            {
                return false;
            }
            else if (lists.Where(x => (string)x.GetType().GetProperty("FlowType").GetValue(x) == (string)t.GetType().GetProperty("FlowType").GetValue(t) 
            &&(int) x.GetType().GetProperty("Initial").GetValue(x) > (int)t.GetType().GetProperty("Initial").GetValue(t)
            && (int)t.GetType().GetProperty("End").GetValue(t) > (int)x.GetType().GetProperty("Initial").GetValue(x)).ToList().Count > 0)
            {
                return false;
            }
            else if (lists.Where(x => (string)x.GetType().GetProperty("FlowType").GetValue(x) == (string)t.GetType().GetProperty("FlowType").GetValue(t) 
            &&(int)x.GetType().GetProperty("Initial").GetValue(x) > (int)t.GetType().GetProperty("Initial").GetValue(t) 
            && (int)t.GetType().GetProperty("End").GetValue(t) == (int)x.GetType().GetProperty("Initial").GetValue(x)).ToList().Count > 0)
            {
                return false;
            }
            else if (lists.Where(x =>(string)x.GetType().GetProperty("FlowType").GetValue(x) == (string)t.GetType().GetProperty("FlowType").GetValue(t)
            &&(int)x.GetType().GetProperty("Initial").GetValue(x) < (int)t.GetType().GetProperty("Initial").GetValue(t)
            && (int)t.GetType().GetProperty("Initial").GetValue(t) ==(int) x.GetType().GetProperty("End").GetValue(x)).ToList().Count > 0)
            {
                return false;
            }

            return true;

        }

    }
}
