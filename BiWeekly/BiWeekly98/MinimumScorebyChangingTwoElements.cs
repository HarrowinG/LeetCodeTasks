using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly98
{
    public class MinimumScorebyChangingTwoElements
    {
        public int MinimizeSum(int[] nums)
        {
            Array.Sort(nums);
            return Math.Min(
                Math.Min(
                Math.Min(
                Math.Min(
                Math.Min(nums[nums.Length - 1] - nums[0], nums[nums.Length - 1] - nums[1]),
                nums[nums.Length - 1] - nums[2]),
                nums[nums.Length - 2] - nums[0]),
                nums[nums.Length - 3] - nums[0]),
                nums[nums.Length - 2] - nums[1]);
        }
    }
}
