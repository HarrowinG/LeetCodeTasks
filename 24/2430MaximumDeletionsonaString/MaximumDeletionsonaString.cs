namespace LeetCodeTasks._2430MaximumDeletionsonaString
{
    public class MaximumDeletionsonaString
    {
        public int DeleteString(string s)
        {
            return TopDown(s);
            //return BottomUp(s);
        }

        public int BottomUp(string s)
        {
            int n = s.Length;
            var lcsRow = new int[n + 1];
            int[] dp = new int[n];
            for (int i = n - 1; i >= 0; i--)
            {
                var lcsCurrent = new int[n + 1];
                dp[i] = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (s[i] == s[j])
                        lcsCurrent[j] = lcsRow[j + 1] + 1;
                    if (lcsCurrent[j] >= j - i)
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                }

                lcsRow = lcsCurrent;
            }
            return dp[0];
        }

        public int TopDown(string s)
        {
            var dp = new int[s.Length];
            return Dfs(s, 0, dp);
        }

        private int Dfs(string s, int id, int[] dp)
        {
            if (dp[id] == 0)
            {
                dp[id] = 1;
                for (int length = 1; dp[id] <= s.Length - id - length; length++)
                {
                    if (string.Compare(s, id, s, id + length, length) == 0) //n^3 works only with string.Compare, manual gives TLE
                        dp[id] = Math.Max(dp[id], Dfs(s, id + length, dp) + 1);
                            
                }
            }

            return dp[id];
        }
    }
}
