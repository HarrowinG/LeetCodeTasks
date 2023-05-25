namespace LeetCodeTasks._837New21Game
{
    public class New21GameClass
    {
        public double New21Game(int n, int k, int maxPts)
        {
            if (k == 0 || n >= k + maxPts) return 1;
            var dp = new double[n + 1];
            double maxPtsSum = 1, result = 0;
            dp[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                dp[i] = maxPtsSum / maxPts;
                if (i < k) maxPtsSum += dp[i];
                else result += dp[i];

                if (i - maxPts >= 0) 
                    maxPtsSum -= dp[i - maxPts];
            }

            return result;
        }
    }
}
