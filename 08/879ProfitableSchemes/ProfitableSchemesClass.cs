namespace LeetCodeTasks._879ProfitableSchemes
{
    public class ProfitableSchemesClass
    {
        public int ProfitableSchemes(int n, int minProfit, int[] group, int[] profit)
        {
            var mod = (int)1e9 + 7;
            var dp = new int[minProfit + 1][];
            for (var i = 0; i <= minProfit; i++)
                dp[i] = new int[n + 1];

            dp[0][0] = 1;

            for (int k = 0; k < group.Length; k++)
            {
                int g = group[k], p = profit[k];
                for (int i = minProfit; i >= 0; i--)
                    for (int j = n - g; j >= 0; j--)
                        dp[Math.Min(i + p, minProfit)][j + g] = (dp[Math.Min(i + p, minProfit)][j + g] + dp[i][j]) % mod;
            }

            var res = 0;
            foreach (var numWays in dp[minProfit])
                res = (res + numWays) % mod;

            return res;
        }
    }
}
