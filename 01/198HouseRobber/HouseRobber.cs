namespace LeetCodeTasks._198HouseRobber
{
    public class HouseRobber
    {
        public int Rob(int[] nums)
        {
            var dp = new int[] { 0, nums[0], 0 };
            for (int i = 1; i < nums.Length; i++)
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
