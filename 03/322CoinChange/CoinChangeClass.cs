namespace LeetCodeTasks._322CoinChange
{
    public class CoinChangeClass
    {
        public int CoinChange(int[] coins, int amount)
        {
            return BottomUp(coins, amount);
        }

        private int BottomUp(int[] coins, int amount)
        {
            var dp = new int[amount + 1];
            for (int i = 1; i <= amount; i++)
            {
                dp[i] = int.MaxValue;
                foreach (var coin in coins)
                {
                    var remainder = i - coin;
                    if (remainder < 0 || dp[remainder] == int.MaxValue) continue;

                    dp[i] = Math.Min(dp[i], dp[remainder] + 1);
                }
            }

            return dp[amount] == int.MaxValue ? -1 : dp[amount];
        }
    }
}
