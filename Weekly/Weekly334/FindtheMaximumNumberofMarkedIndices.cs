using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly334
{
    public class FindtheMaximumNumberofMarkedIndices
    {
        public int MaxNumOfMarkedIndices(int[] nums)
        {
            var res = 0;
            Array.Sort(nums);
            var j = nums.Length - 1;
            for (var i = nums.Length / 2 - 1; i >= 0; i--)
            {
                if (nums[i] <= nums[j] / 2)
                {
                    res += 2;
                    j--;
                }
            }

            return res;
        }
    }
}
