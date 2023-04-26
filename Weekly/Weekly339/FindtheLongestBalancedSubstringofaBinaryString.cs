using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly339
{
    public class FindtheLongestBalancedSubstringofaBinaryString
    {
        public int FindTheLongestBalancedSubstring(string s)
        {
            var result = 0;
            var zeros = s[0] == '0' ? 1 : 0;
            var ones = 0;
            var wasZero = s[0] == '0';
            for (var i = 1; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    if (wasZero) zeros++;
                    else
                    {
                        result = Math.Max(result, Math.Min(zeros, ones) * 2);
                        zeros = 1;
                    }
                    wasZero = true;
                }
                else
                {
                    if (wasZero) ones = 1;
                    else ones++;
                    wasZero = false;
                }
            }

            if (!wasZero)
            {
                result = Math.Max(result, Math.Min(zeros, ones) * 2);
            }
            return result;
        }
    }
}
