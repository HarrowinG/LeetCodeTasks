using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly342
{
    public class MinimumNumberofOperationstoMakeAllArrayElementsEqualto1
    {
        //todo
        public int MinOperations(int[] nums)
        {
            var res = Dfs(nums);

            return -1;
        }

        private int Dfs(int[] nums)
        {
            var wasChange = false;
            var min = int.MaxValue;
            for (var i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    wasChange = true;
                    var gcd = (int)BigInteger.GreatestCommonDivisor(nums[i], nums[i + 1]);
                    if (nums[i] != gcd)
                    {
                        var temp = nums[i];
                        nums[i] = gcd;
                        min = Dfs(nums) + 1;
                        nums[i] = temp;
                    }
                    else if (nums[i + 1] != gcd)
                    {
                        var temp = nums[i + 1];
                        nums[i + 1] = gcd;
                        min = Dfs(nums) + 1;
                        nums[i + 1] = temp;
                    }
                    else
                    {
                        min = Dfs(nums);
                    }
                }
            }

            return wasChange ? min 
                : nums[0] == 1 ? 0 : -1;
        }
    }
}
