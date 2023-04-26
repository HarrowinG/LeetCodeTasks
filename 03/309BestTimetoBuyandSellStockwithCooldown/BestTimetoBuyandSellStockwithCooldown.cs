namespace LeetCodeTasks._309BestTimetoBuyandSellStockwithCooldown
{
    public class BestTimetoBuyandSellStockwithCooldown
    {
        public int MaxProfit(int[] prices)
        {
            //return TopDown(prices);
            return BottomUp(prices);
        }

        private int BottomUp(int[] prices)
        {
            var row = new int[] { 0, -prices[0], int.MinValue }; //cooldown, buy, sell
            for (int i = 1; i < prices.Length; i++)
            {
                var cooldown = row[0];
                row[0] = Math.Max(row[0], row[2]);
                row[2] = row[1] + prices[i];
                row[1] = Math.Max(row[1], cooldown - prices[i]);
            }

            return Math.Max(row[0], row[2]);
        }

        private int TopDown(int[] prices)
        {
            var dp = new int[prices.Length, 2];//1 - buy, 0 - sell
            return Dfs(prices, 0, dp, 1);
        }

        private int Dfs(int[] prices, int id, int[,] dp, int isBuy)
        {
            if (id >= prices.Length) return 0;

            if (dp[id, isBuy] == 0)
            {
                if (isBuy == 1)
                {
                    dp[id, isBuy] += Math.Max(Dfs(prices, id + 1, dp, 0) - prices[id], 
                                              Dfs(prices, id + 1, dp, 1));
                }
                else
                {
                    dp[id, isBuy] += Math.Max(Dfs(prices, id + 2, dp, 1) + prices[id],
                                              Dfs(prices, id + 1, dp, 0));
                }

                dp[id, isBuy] += 1;
            }

            return dp[id, isBuy] - 1;
        }
    }
}
