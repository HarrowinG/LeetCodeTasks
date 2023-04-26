using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly100
{
    public class MaximizeGreatnessofanArray
    {
        public int MaximizeGreatness(int[] nums)
        {
            Array.Sort(nums);
            var l = nums.Length - 2;
            var r = nums.Length - 1;

            var result = 0;
            while (l >= 0)
            {
                if (nums[l] < nums[r])
                {
                    result++;
                    r--;
                }

                l--;
            }

            return result;
        }
    }
}
