using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly334
{
    public class LeftandRightSumDifferences
    {
        public int[] LeftRigthDifference(int[] nums)
        {
            var leftSum = new int[nums.Length];
            var rightSum = new int[nums.Length];
            for (var i = 1; i < nums.Length; i++)
            {
                leftSum[i] = nums[i - 1] + leftSum[i - 1];
            }
            for (var i = nums.Length - 2; i >= 0; i--)
            {
                rightSum[i] = nums[i + 1] + rightSum[i + 1];
            }
            for (var i = 0; i < nums.Length; i++)
            {
                leftSum[i] = Math.Abs(leftSum[i] - rightSum[i]);
            }

            return leftSum;
        }
    }
}
