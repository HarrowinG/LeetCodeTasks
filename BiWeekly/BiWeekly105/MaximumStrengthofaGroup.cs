using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly105
{
    public class MaximumStrengthofaGroup
    {
        public long MaxStrength(int[] nums)
        {
            var list = nums.Where(x => x != 0).ToList();
            var wasZero = list.Count != nums.Length;
            if (list.Count == 0) return 0;
            if (list.Count == 1 && list[0] < 0)
                return wasZero ? 0 : list[0];

            var dp = new long[] { 1, 1 };
            for (var i = list.Count - 1; i >= 0; i--)
            {
                var num = list[i];
                var temp = dp[0];
                dp[0] = Math.Max(dp[0], Math.Max(dp[0] * num, dp[1] * num));
                dp[1] = Math.Min(dp[1], Math.Min(dp[1] * num, temp * num));
            }

            var max = Math.Max(dp[0], dp[1]);
            return max < 0 && wasZero ? 0 : max;
        }
    }
}
