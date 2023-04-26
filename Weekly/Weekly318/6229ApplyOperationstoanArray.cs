using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly318
{
    public class _6229ApplyOperationstoanArray
    {
        public int[] ApplyOperations(int[] nums)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums[i] *= 2;
                    nums[i + 1] = 0;
                }
            }

            var id = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[id] = nums[i];
                    id++;
                }
            }

            for (var i = id; i < nums.Length; i++)
                nums[i] = 0;

            return nums;
        }
    }
}
