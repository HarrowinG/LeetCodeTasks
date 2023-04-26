namespace LeetCodeTasks._518CoinChangeII
{
    public class CoinChangeII
    {
        public int Change(int amount, int[] coins)
        {
            //return TopDown(amount, coins);
            return BottomUp(amount, coins);
        }

        private int TopDown(int amount, int[] coins)
        {
            var dp = new int[amount + 1, coins.Length];
            return Dfs(amount, coins, 0, dp);
        }

        private int Dfs(int amount, int[] coins, int id, int[,] dp)
        {
            if (amount == 0) return 1;
            if (id == coins.Length || amount < 0) return 0;
            
            if (dp[amount, id] == 0)
            {
                dp[amount, id] += Dfs(amount - coins[id], coins, id, dp) + Dfs(amount, coins, id + 1, dp);
                dp[amount, id]++;
            }

            return dp[amount, id] - 1;
        }

        private int BottomUp(int amount, int[] coins)
        {
            var row = new int[amount + 1];
            for (var i = 0; i < coins.Length; i++)
            {
                var current = new int[amount + 1];
                current[0] = 1;
                for (var j = 1; j <= amount; j++)
                {
                    current[j] = row[j];
                    var delta = j - coins[i];
                    if (delta < 0) continue;

                    current[j] += current[delta];
                }

                row = current;
            }

            return row[amount];
        }
    }
}
