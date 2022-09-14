using System.Collections.Generic;
using System.Linq;

namespace Economy.AppCore.Processes
{
    public static class ValidateInterest

    {
        public static int Validar<T>(List<object> lists, T t)
        {

            int i = lists.Where(x => (string)x.GetType().GetProperty("FlowType").GetValue(x) == (string)t.GetType().GetProperty("FlowType").GetValue(t)
             && (int)t.GetType().GetProperty("Initial").GetValue(t) >= (int)x.GetType().GetProperty("Initial").GetValue(x)
             && (int)t.GetType().GetProperty("Initial").GetValue(t) <= (int)x.GetType().GetProperty("End").GetValue(x)
             || (int)t.GetType().GetProperty("End").GetValue(t) >= (int)x.GetType().GetProperty("Initial").GetValue(x)
             || (int)t.GetType().GetProperty("End").GetValue(t) <= (int)x.GetType().GetProperty("End").GetValue(x)
             || (int)t.GetType().GetProperty("Initial").GetValue(t) < (int)x.GetType().GetProperty("Initial").GetValue(x)
             && (int)x.GetType().GetProperty("End").GetValue(x) < (int)t.GetType().GetProperty("End").GetValue(t)
            ).Count();








            //if (lists.Where(x =>(string) x.GetType().GetProperty("FlowType").GetValue(x) == (string)t.GetType().GetProperty("FlowType").GetValue(t) 
            //&&(int) x.GetType().GetProperty("Initial").GetValue(x) == (int)t.GetType().GetProperty("Initial").GetValue(t)
            //&& (int)t.GetType().GetProperty("End").GetValue(t) > (int)x.GetType().GetProperty("End").GetValue(x)).ToList().Count > 0)
            //{
            //    return false;
            //}
            //else if (lists.Where(x => (string)x.GetType().GetProperty("FlowType").GetValue(x) == (string)t.GetType().GetProperty("FlowType").GetValue(t) 
            //&& (int)x.GetType().GetProperty("Initial").GetValue(x) <= (int)t.GetType().GetProperty("Initial").GetValue(t)
            //&& (int)t.GetType().GetProperty("End").GetValue(t) <= (int)x.GetType().GetProperty("End").GetValue(x)).ToList().Count > 0)
            //{
            //    return false;
            //}
            //else if (lists.Where(x => (string)x.GetType().GetProperty("FlowType").GetValue(x) == (string)t.GetType().GetProperty("FlowType").GetValue(t) 
            //&&(int)x.GetType().GetProperty("Initial").GetValue(x) < (int)t.GetType().GetProperty("Initial").GetValue(t)
            //&& (int)x.GetType().GetProperty("End").GetValue(x) > (int)t.GetType().GetProperty("Initial").GetValue(t)).ToList().Count > 0)
            //{
            //    return false;
            //}
            //else if (lists.Where(x => (string)x.GetType().GetProperty("FlowType").GetValue(x) == (string)t.GetType().GetProperty("FlowType").GetValue(t) 
            //&&(int) x.GetType().GetProperty("Initial").GetValue(x) > (int)t.GetType().GetProperty("Initial").GetValue(t)
            //&& (int)t.GetType().GetProperty("End").GetValue(t) > (int)x.GetType().GetProperty("Initial").GetValue(x)).ToList().Count > 0)
            //{
            //    return false;
            //}
            //else if (lists.Where(x => (string)x.GetType().GetProperty ("FlowType").GetValue(x) == (string)t.GetType().GetProperty("FlowType").GetValue(t) 
            //&&(int)x.GetType().GetProperty("Initial").GetValue(x) > (int)t.GetType().GetProperty("Initial").GetValue(t) 
            //&& (int)t.GetType().GetProperty("End").GetValue(t) == (int)x.GetType().GetProperty("Initial").GetValue(x)).ToList().Count > 0)
            //{
            //    return false;
            //}
            //else if (lists.Where(x =>(string)x.GetType().GetProperty("FlowType").GetValue(x) == (string)t.GetType().GetProperty("FlowType").GetValue(t)
            //&&(int)x.GetType().GetProperty("Initial").GetValue(x) < (int)t.GetType().GetProperty("Initial").GetValue(t)
            //&& (int)t.GetType().GetProperty("Initial").GetValue(t) ==(int) x.GetType().GetProperty("End").GetValue(x)).ToList().Count > 0)
            //{
            //    return false;
            //}

            //return true;
            return i;
        }

    }
}
