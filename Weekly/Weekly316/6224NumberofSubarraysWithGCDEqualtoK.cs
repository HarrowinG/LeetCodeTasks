using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly316
{
    public class _6224NumberofSubarraysWithGCDEqualtoK
    {
        public int SubarrayGCD(int[] nums, int k)
        {
            var count = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] % k != 0) continue;
                BigInteger gcd = nums[i];
                for (var j = i; j < nums.Length; j++)
                {
                    if (nums[i] % k != 0) break;

                    gcd = BigInteger.GreatestCommonDivisor(gcd, nums[j]);
                    if (gcd == k) count++;
                }
            }

            return count;
        }
    }
}
