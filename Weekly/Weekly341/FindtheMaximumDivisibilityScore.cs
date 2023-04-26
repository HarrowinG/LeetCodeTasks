using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly341
{
    public class FindtheMaximumDivisibilityScore
    {
        public int MaxDivScore(int[] nums, int[] divisors)
        {
            var dict = new Dictionary<int, int>();
            var max = 0;
            var res = divisors[0];

            for (var i = 0; i < divisors.Length; i++)
            {
                var count = 0;
                if (!dict.ContainsKey(divisors[i]))
                {
                    for (var j = 0; j < nums.Length; j++)
                    {
                        if (nums[j] % divisors[i] == 0)
                            count++;
                    }

                    dict[divisors[i]] = count;
                }
                else count = dict[divisors[i]];

                if (count >= max)
                {
                    if (count == max)
                        res = Math.Min(res, divisors[i]);
                    else res = divisors[i];

                    max = count;
                }
            }

            return res;
        }
    }
}
