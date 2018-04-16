using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Planner_EF
{
    public static class Parser
    {
        public static int? ToNullableInt(string s)
        {
            int i;
            if (int.TryParse(s, out i)) return i;
            return null;
        }
        public static decimal? ToNullableDecimal(string s)
        {
            decimal i;
            if (decimal.TryParse(s, out i)) return i;
            return null;
        }
    }
}
