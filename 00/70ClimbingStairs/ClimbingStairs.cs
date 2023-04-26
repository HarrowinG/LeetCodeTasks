namespace LeetCodeTasks._70ClimbingStairs
{
    public class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            var dp = new int[] { 1, 1, 0 };
            for (int i = 1; i < n; i++)
            {
                dp[2] = dp[0] + dp[1];
                dp[0] = dp[1];
                dp[1] = dp[2];
            }

            return dp[1];
        }
    }
}
