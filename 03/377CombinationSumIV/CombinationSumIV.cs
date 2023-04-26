using System;

namespace LeetCodeTasks._377CombinationSumIV
{
    public class CombinationSumIV
    {
        public int CombinationSum4(int[] nums, int target)
        {
            return TopDown(nums, target);
            //return BottomUp(nums, target);
        }

        private int BottomUp(int[] nums, int target)
        {
            var dp = new int[target + 1];
            dp[0] = 1;

            for (int i = 1; i < dp.Length; i++)
            {
                var sum = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    var reminder = i - nums[j];
                    if (reminder < 0) continue;

                    sum += dp[reminder];
                }

                dp[i] = sum;
            }

            return dp[target];
        }

        private int TopDown(int[] nums, int target)
        {
            var memo = new int[target + 1];
            Array.Fill(memo, -1);
            memo[0] = 1;
            return Dfs(nums, target, memo);
        }

        private int Dfs(int[] nums, int target, int[] memo)
        {
            if (memo[target] != -1) return memo[target];

            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (target >= nums[i])
                {
                    sum += Dfs(nums, target - nums[i], memo);
                }
            }

            memo[target] = sum;
            return sum;
        }
    }
}
