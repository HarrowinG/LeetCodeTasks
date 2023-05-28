using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly347
{
    public class MinimumCosttoMakeAllCharactersEqual
    {
        public long MinimumCost(string s)
        {
            long result = 0;
            for (var i = 1; i < s.Length; i++)
                if (s[i] != s[i - 1]) result += Math.Min(i, s.Length - i);

            return result;
        }
    }
}
