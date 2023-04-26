using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly341
{
    public class MinimumAdditionstoMakeValidString
    {
        public int AddMinimum(string word)
        {
            var result = 0;
            for (var i = 0; i < word.Length;)
            {
                if (i + 2 < word.Length)
                {
                    var tripple = word.Substring(i, 3);
                    if (tripple == "abc")
                    {
                        i += 3;
                        continue;
                    }
                }

                if (i + 1 < word.Length)
                {
                    var pair = word.Substring(i, 2);
                    if (pair == "ab" || pair == "ac" || pair == "bc")
                    {
                        i += 2;
                        result++;
                        continue;
                    }
                }

                i++;
                result += 2;
            }

            return result;
        }
    }
}
