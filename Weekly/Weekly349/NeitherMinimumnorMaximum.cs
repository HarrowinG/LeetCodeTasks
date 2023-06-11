using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly349
{
    public class NeitherMinimumnorMaximum
    {
        public int FindNonMinOrMax(int[] nums)
        {
            if (nums.Length < 3) return -1;

            Array.Sort(nums);
            return nums[1];
        }
    }
}
