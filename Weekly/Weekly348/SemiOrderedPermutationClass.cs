using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly348
{
    public class SemiOrderedPermutationClass
    {
        public int SemiOrderedPermutation(int[] nums)
        {
            var result = 0;
            for (var i = 0; i < nums.Length; i++)
                if (nums[i] == 1)
                {
                    result += i;
                    break;
                }

            var n = nums.Length;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == n)
                {
                    if (result > i) result--;
                    result += (n - i - 1);
                    break;
                }
            }

            return result;
        }
    }
}
