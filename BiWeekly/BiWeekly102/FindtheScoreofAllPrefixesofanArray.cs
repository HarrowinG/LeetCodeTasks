using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly102
{
    public class FindtheScoreofAllPrefixesofanArray
    {
        public long[] FindPrefixScore(int[] nums)
        {
            var result = new long[nums.Length];
            var max = nums[0];
            result[0] = nums[0] + max;
            for (var i = 1; i < nums.Length; i++)
            {
                max = Math.Max(max, nums[i]);
                result[i] = nums[i] + max + result[i - 1];
            }

            return result;
        }
    }
}
