namespace LeetCodeTasks._2218MaximumValueofKCoinsFromPiles
{
    public class MaximumValueofKCoinsFromPiles
    {
        public int MaxValueOfCoins(IList<IList<int>> piles, int k)
        {
            var dp = new int[piles.Count + 1][];
            return Dfs(piles, dp, 0, k);
        }

        private int Dfs(IList<IList<int>> piles, int[][] dp, int pileId, int k)
        {
            if (k == 0 || pileId == piles.Count) return 0;
            if (dp[pileId] == null) dp[pileId] = new int[k + 1];

            if (dp[pileId][k] == 0)
            {
                dp[pileId][k] = Dfs(piles, dp, pileId + 1, k);
                var sum = 0;

                var leftToTake = Math.Min(piles[pileId].Count, k);
                for (var j = 0; j < leftToTake; j++)
                {
                    sum += piles[pileId][j];
                    dp[pileId][k] = Math.Max(dp[pileId][k], sum + Dfs(piles, dp, pileId + 1, k - j - 1));
                }

                dp[pileId][k]++;
            }

            return dp[pileId][k] - 1;
        }
    }
}
