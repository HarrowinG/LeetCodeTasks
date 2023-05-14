using System.Numerics;

namespace LeetCodeTasks._1799MaximizeScoreAfterNOperations
{
    public class MaximizeScoreAfterNOperations
    {
        public int MaxScore(int[] nums)
        {
            var dimension = 1 << nums.Length;
            var dp = new int[nums.Length / 2 + 1][];
            for (var i = 0; i < dp.Length; i++)
                dp[i] = new int[dimension];

            return Dfs(nums, dp, 1, 0);
        }

        private int Dfs(int[] nums, int[][] dp, int i, int mask)
        {
            if (i > nums.Length / 2)
                return 0;
            if (dp[i][mask] == 0)
                for (int j = 0; j < nums.Length; ++j)
                    for (int k = j + 1; k < nums.Length; ++k)
                    {
                        int new_mask = (1 << j) + (1 << k);
                        if ((mask & new_mask) == 0)
                            dp[i][mask] = Math.Max(dp[i][mask], i * Gcd(nums[j], nums[k]) + Dfs(nums, dp, i + 1, mask + new_mask));
                    }
            return dp[i][mask];
        }

        private int Gcd(int a, int b)
        {
            return b == 0 ? a : (int)BigInteger.GreatestCommonDivisor(b, a % b);
        }
    }
}
