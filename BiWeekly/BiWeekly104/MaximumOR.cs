using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly104
{
    public class MaximumOR
    {
        public long MaximumOr(int[] nums, int k)
        {
            var pows = new long[k + 1];
            pows[0] = 1;
            for (var i = 1; i <= k; i++)
                pows[i] = pows[i - 1] * 2;

            var dp = new long[nums.Length][];
            for (var i = 0; i < dp.Length; i++)
                dp[i] = Enumerable.Repeat(-1L, k + 1).ToArray();

            return Dfs(pows, nums, k, 0, dp);
        }

        private long Dfs(long[] pows, int[] nums, int k, int id, long[][] dp)
        {
            if (id >= nums.Length) return 0;
            if (dp[id][k] != -1) return dp[id][k];

            var max = 0L;
            for (var i = 0; i <= k; i++)
                max = Math.Max(max, pows[i] * nums[id] | Dfs(pows, nums, k - i, id + 1, dp));

            dp[id][k] = max;
            return dp[id][k];
        }
    }
}
