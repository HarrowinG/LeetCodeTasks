using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly318
{
    public class _6230MaximumSumofDistinctSubarraysWithLengthK
    {
        public long MaximumSubarraySum(int[] nums, int k)
        {
            long max = 0;
            long sum = 0;
            var set = new HashSet<int>();
            var l = 0;
            for (var r = 0; r < k; r++)
            {
                set.Add(nums[r]);
                sum += nums[r];
            }
            if (set.Count == k)
                max = Math.Max(max, sum);

            for (var r = k; r < nums.Length; r++)
            {
                set.Remove(nums[l]);
                set.Add(nums[r]);
                sum -= nums[l];
                sum += nums[r];
                l++;
                set.Add(nums[l]);
                if (set.Count == k)
                    max = Math.Max(max, sum);
            }

            return max;
        }
    }
}
