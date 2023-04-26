namespace LeetCodeTasks._494TargetSum
{
    public class TargetSum
    {
        public int FindTargetSumWays(int[] nums, int target)
        {
            //return TopDown(nums, target);
            return BottomUp(nums, target);
        }

        private int BottomUp(int[] nums, int target)
        {
            var total = nums.Sum();
            if (Math.Abs(target) > total) return 0;

            var row = new int[2 * total + 1];
            row[nums[0] + total] = 1;
            row[-nums[0] + total] += 1;

            for (int i = 1; i < nums.Length; i++)
            {
                var current = new int[2 * total + 1];
                for (int sum = -total; sum <= total; sum++)
                {
                    if (row[sum + total] > 0)
                    {
                        current[sum + nums[i] + total] += row[sum + total];
                        current[sum - nums[i] + total] += row[sum + total];
                    }
                }

                row = current;
            }

            return row[target + total];
        }

        private int TopDown(int[] nums, int target)
        {
            var dp = new Dictionary<int, int>[nums.Length];
            return Dfs(nums, 0, target, dp);
        }

        private int Dfs(int[] nums, int id, int target, Dictionary<int, int>[] dp)
        {
            if (id == nums.Length)
                return target == 0 ? 1 : 0;

            if (dp[id] == null) dp[id] = new Dictionary<int, int>();
            if (!dp[id].ContainsKey(target))
            {
                dp[id][target] = Dfs(nums, id + 1, target - nums[id], dp)
                               + Dfs(nums, id + 1, target + nums[id], dp);
            }

            return dp[id][target];
        }
    }
}
