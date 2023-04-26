namespace LeetCodeTasks._1312MinimumInsertionStepstoMakeaStringPalindrome
{
    public class MinimumInsertionStepstoMakeaStringPalindrome
    {
        public int MinInsertions(string s)
        {
            //return TopDown(s);
            return BottomUp(s);
        }

        //longest palindromic subsequence 516
        private int BottomUp(string s)
        {
            var dp = new int[s.Length];
            for (var l = s.Length - 1; l >= 0; l--)
            {
                var current = new int[s.Length];
                current[l] = 1;
                for (var r = l + 1; r < s.Length; r++)
                {
                    if (s[l] == s[r])
                        current[r] = dp[r - 1] + 2;
                    else
                        current[r] = Math.Max(dp[r], current[r - 1]);
                }

                dp = current;
            }

            return s.Length - dp[s.Length - 1];
        }

        private int TopDown(string s)
        {
            var dp = new int[s.Length][];
            return Dfs(s, 0, s.Length - 1, dp);
        }

        private int Dfs(string s, int l, int r, int[][] dp)
        {
            if (l >= r) return 0;
            if (dp[l] == null) dp[l] = new int[s.Length];
            
            if (dp[l][r] == 0)
            {
                if (s[l] == s[r])
                    dp[l][r] = Dfs(s, l + 1, r - 1, dp);
                else
                    dp[l][r] = Math.Min(Dfs(s, l + 1, r, dp), Dfs(s, l, r - 1, dp)) + 1;

                dp[l][r]++;
            }

            return dp[l][r] - 1;
        }
    }
}
