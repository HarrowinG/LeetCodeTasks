namespace LeetCodeTasks._213HouseRobberII
{
    public class HouseRobberII
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            return Math.Max(Rob(nums, 0), Rob(nums, 1));
        }

        private int Rob(int[] nums, int start)
        {
            var n = start == 0 ? nums.Length - 1 : nums.Length;
            var dp = new int[] { 0, nums[start], 0 };
            for (int i = start + 1; i < n; i++)
            {
                var sum = dp[0] + nums[i];
                if (sum > dp[1]) dp[2] = sum;
                else dp[2] = dp[1];

                dp[0] = dp[1];
                dp[1] = dp[2];
            }

            return dp[1];
        }
    }
}
