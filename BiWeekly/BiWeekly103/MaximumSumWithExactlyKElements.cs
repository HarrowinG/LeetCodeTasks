using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly103
{
    public class MaximumSumWithExactlyKElements
    {
        public int MaximizeSum(int[] nums, int k)
        {
            var max = nums.Max();
            var result = max * k;
            for (var i = 0; i < k; i++)
            {
                result += i;
            }

            return result;
        }
    }
}
