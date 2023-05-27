using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly105
{
    public class ExtraCharactersinaString
    {
        public int MinExtraChar(string s, string[] dictionary)
        {
            var dp = new int[s.Length + 1];
            for (var i = s.Length - 1;  i >= 0; i--)
            {
                dp[i] = dp[i + 1] + 1;
                foreach(var word in dictionary)
                {
                    if (i + word.Length > s.Length) continue;

                    var substr = s[i..(i + word.Length)];
                    if (substr == word)
                    {
                        dp[i] = Math.Min(dp[i], dp[i + word.Length]);
                    }
                }
            }

            return dp[0];
        }
    }
}
