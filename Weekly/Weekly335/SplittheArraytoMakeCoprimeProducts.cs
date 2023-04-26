using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly335
{
    //todo
    public class SplittheArraytoMakeCoprimeProducts
    {
        public int FindValidSplit(int[] nums)
        {
            var modulo = 1000000000007;
            var prefix = new long[nums.Length];
            var suffix = new long[nums.Length];
            var n = nums.Length;
            prefix[0] = nums[0];
            for (var i = 1; i < n - 1; i++)
            {
                prefix[i] = prefix[i - 1] * nums[i] % modulo;
            }
            suffix[n - 1] = nums[n - 1];
            for (var i = n - 2; i > 0; i--)
            {
                suffix[i] = suffix[i + 1] * nums[i] % modulo;
            }
            
            for (var i = 0; i < n - 1; i++)
            {
                var gcd = BigInteger.GreatestCommonDivisor(prefix[i], suffix[i + 1]);
                if (gcd == 1) return i;
            }

            return -1;
        }
    }
}
