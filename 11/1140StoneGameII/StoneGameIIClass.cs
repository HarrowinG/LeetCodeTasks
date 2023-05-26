namespace LeetCodeTasks._1140StoneGameII
{
    public class StoneGameIIClass
    {
        public int StoneGameII(int[] piles)
        {
            var suffixSum = new int[piles.Length + 1];
            for (var i = piles.Length - 1; i >= 0; i--)
                suffixSum[i] = piles[i] + suffixSum[i + 1];

            var dp = new int[piles.Length + 1][];
            for (var i = 0; i <= piles.Length; i++)
            {
                dp[i] = new int[piles.Length + 1];
                dp[i][piles.Length] = suffixSum[i];
            }

            for (var i = piles.Length - 1; i >= 0; i--)
                for (var m = piles.Length - 1; m >= 1; m--)
                    for (var x = 1; x <= 2 * m && i + x <= piles.Length; x++)
                        dp[i][m] = Math.Max(dp[i][m], suffixSum[i] - dp[i + x][Math.Max(x, m)]);

            return dp[0][1];
        }
    }
}
