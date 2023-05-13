namespace LeetCodeTasks._2466CountWaysToBuildGoodStrings
{
    public class CountWaysToBuildGoodStrings
    {
        public int CountGoodStrings(int low, int high, int zero, int one)
        {
            var modulo = (int)1e9 + 7;
            var dp = new int[high + 1];
            dp[0] = 1;

            var result = 0;
            for (var i = 1; i <= high; i++)
            {
                if (i >= zero) dp[i] = (dp[i] + dp[i - zero]) % modulo;
                if (i >= one) dp[i] = (dp[i] + dp[i - one]) % modulo;
                if (i >= low) result = (result + dp[i]) % modulo;
            }

            return result;
        }
    }
}
