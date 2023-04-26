using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly101
{
    public class FindtheSubstringWithMaximumCost
    {
        public int MaximumCostSubstring(string s, string chars, int[] vals)
        {
            var max = 0;
            var current = 0;
            var dict = new Dictionary<char, int>();
            for (var i = 0; i < chars.Length; i++)
                dict[chars[i]] = i;

            foreach (var c in s)
            {
                if (!dict.ContainsKey(c))
                {
                    current += c - 'a' + 1;
                }
                else
                {
                    current += vals[dict[c]];
                }

                if (current < 0) current = 0;
                if (current > max) max = current;
            }

            return max;
        }
    }
}
