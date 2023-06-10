using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly106
{
    public class FindtheLongestSemiRepetitiveSubstring
    {
        //wrong
        public int LongestSemiRepetitiveSubstring(string s)
        {
            var max = 1;
            var l = 0;
            var lastPairIndex = 0;
            for (var r = 1; r < s.Length; r++)
            {
                if (s[r] == s[r - 1])
                {
                    var delta = r - lastPairIndex;
                    if (delta == 1) l = r - 1;
                    else if (delta == 2) l = r - 2;

                    lastPairIndex = r;
                }

                max = Math.Max(max, r - l + 1);
            }

            return max;
        }
    }
}
