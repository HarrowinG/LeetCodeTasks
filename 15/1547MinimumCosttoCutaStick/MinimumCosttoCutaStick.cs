namespace LeetCodeTasks._1547MinimumCosttoCutaStick
{
    public class MinimumCosttoCutaStick
    {
        public int MinCost(int n, int[] cuts)
        {
            var listCuts = new List<int>();
            foreach (var cut in cuts)
                listCuts.Add(cut);
            listCuts.Add(0);
            listCuts.Add(n);
            listCuts.Sort();
            int[][] dp = new int[listCuts.Count][];

            for (int i = listCuts.Count - 1; i >= 0; i--)
            {
                dp[i] = new int[listCuts.Count];
                for (int j = i + 1; j < listCuts.Count; j++)
                {
                    for (int k = i + 1; k < j; k++)
                        dp[i][j] = Math.Min(dp[i][j] == 0 ? int.MaxValue : dp[i][j],
                            listCuts[j] - listCuts[i] + dp[i][k] + dp[k][j]);
                }
            }
                
            return dp[0][listCuts.Count - 1];
        }
    }
}
