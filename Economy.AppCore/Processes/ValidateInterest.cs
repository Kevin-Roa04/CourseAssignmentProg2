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
           

            if (lists.Where(x => x.GetType().GetProperty("FlowType").GetValue(x) == (string)t.GetType().GetProperty("FlowType").GetValue(t) && x.Initial == (int)t.GetType().GetProperty("Initial").GetValue(t) && (int)t.GetType().GetProperty("End").GetValue(t) > x.End).ToList().Count > 0)
            {
                return false;
            }
            else if (lists.Where(x => x.initial == (string)t.GetType().GetProperty("FlowType").GetValue(t) && x.Initial <= (int)t.GetType().GetProperty("Initial").GetValue(t) && (int)t.GetType().GetProperty("End").GetValue(t) <= x.End).ToList().Count > 0)
            {
                return false;
            }
            else if (lists.Where(x => x. == (string)t.GetType().GetProperty("FlowType").GetValue(t) && x.Initial < (int)t.GetType().GetProperty("Initial").GetValue(t) && x.End > (int)t.GetType().GetProperty("Initial").GetValue(t)).ToList().Count > 0)
            {
                return false;
            }
            else if (lists.Where(x => x. == (string)t.GetType().GetProperty("FlowType").GetValue(t) && x.Initial > (int)t.GetType().GetProperty("Initial").GetValue(t) && (int)t.GetType().GetProperty("End").GetValue(t) > x.Initial).ToList().Count > 0)
            {
                return false;
            }
            else if (lists.Where(x => x. == (string)t.GetType().GetProperty("FlowType").GetValue(t) && x.Initial > (int)t.GetType().GetProperty("Initial").GetValue(t) && (int)t.GetType().GetProperty("End").GetValue(t) == x.Initial).ToList().Count > 0)
            {
                return false;
            }
            else if (lists.Where(x => x. == (string)t.GetType().GetProperty("FlowType").GetValue(t) && x.Initial < (int)t.GetType().GetProperty("Initial").GetValue(t) && (int)t.GetType().GetProperty("Initial").GetValue(t) == x.End).ToList().Count > 0)
            {
                return false;
            }

            return true;
        }

    }
}
