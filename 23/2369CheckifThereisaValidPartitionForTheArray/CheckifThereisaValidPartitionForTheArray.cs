namespace LeetCodeTasks._2369CheckifThereisaValidPartitionForTheArray
{
    public class CheckifThereisaValidPartitionForTheArray
    {
        public bool ValidPartition(int[] nums)
        {
            bool[] dp = { true, false, nums[0] == nums[1], false };
            for (var i = 2; i < nums.Length; i++)
            {
                bool two = nums[i] == nums[i - 1];
                bool three = (two && nums[i] == nums[i - 2]) || (nums[i] - 1 == nums[i - 1] && nums[i] - 2 == nums[i - 2]);
                var dpI = i + 1;
                dp[dpI % 4] = (two && dp[(dpI - 2) % 4]) || (three && dp[(dpI - 3) % 4]);
            }
            return dp[nums.Length % 4];
        }

        public bool ValidPartitionDfs(int[] nums)
        {
            return Dfs(nums, nums.Length - 1, new bool?[nums.Length]);
        }

        private bool Dfs(int[] nums, int n, bool?[] memo)
        {
            if (n == -1) return true;
            if (n - 1 < 0) return false;
            if (memo[n] != null) return memo[n].Value;

            var equal = true;
            var increasing = true;

            if (equal && nums[n - 1] != nums[n])
            {
                equal = false;
            }

            if (increasing && nums[n - 1] + 1 != nums[n])
            {
                increasing = false;
            }

            if (!equal && !increasing)
            {
                memo[n] = false;
                return false;
            }

            var stillPartitioned = false;
            if (n - 2 >= 0)
            {
                if ((equal && nums[n - 2] == nums[n - 1])
                    || (increasing && nums[n - 2] + 1 == nums[n - 1]))
                {
                    stillPartitioned = Dfs(nums, n - 3, memo);
                }
            }

            if (!stillPartitioned && equal)
            {
                stillPartitioned = Dfs(nums, n - 2, memo);
            }

            memo[n] = stillPartitioned;
            if (!stillPartitioned) return false;

            return stillPartitioned;
        }
    }
}
