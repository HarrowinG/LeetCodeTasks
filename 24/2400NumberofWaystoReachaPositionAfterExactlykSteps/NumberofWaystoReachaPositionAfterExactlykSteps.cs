namespace LeetCodeTasks._2400NumberofWaystoReachaPositionAfterExactlykSteps
{
    public class NumberofWaystoReachaPositionAfterExactlykSteps
    {
        private const int _module = 1000000007;
        public int NumberOfWays(int startPos, int endPos, int k)
        {
            //return TopDown(startPos, endPos, k);
            return BottomUp(startPos, endPos, k);
        }

        private int BottomUp(int startPos, int endPos, int k)
        {
            var dp = new int[1001, 1001];
            for (int kk = 1; kk <= 1000; kk++)
            {
                dp[kk, kk] = 1;
                for (int i = 0; i < kk; i++)
                    dp[kk, i] = (dp[kk - 1, Math.Abs(i - 1)] + dp[kk - 1, i + 1]) % _module;
            }

            return dp[k, Math.Abs(startPos - endPos)];
        }

        private int TopDown(int startPos, int endPos, int k)
        {
            var dp = new int[1001, 1001];
            return Dfs(Math.Abs(startPos - endPos), k, dp);
        }

        private int Dfs(int distance, int k, int[,] dp)
        {
            if (distance >= k)
            {
                return distance == k ? 1 : 0;
            }

            if (dp[distance, k] == 0)
            {
                dp[distance, k] = (Dfs(distance + 1, k - 1, dp) + Dfs(Math.Abs(distance - 1), k - 1, dp) + 1) % _module;
            }

            return dp[distance, k] - 1;
        }
    }
}
