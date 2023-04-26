namespace LeetCodeTasks._516LongestPalindromicSubsequence
{
    public class LongestPalindromicSubsequence
    {
        public int LongestPalindromeSubseq(string s)
        {
            //return TopDown(s);
            return BottomUp(s);
        }

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

            return dp[s.Length - 1];
        }

        private int TopDown(string s)
        {
            var dp = new int[s.Length][];
            return Dp(dp, s, 0, s.Length - 1);
        }

        private int Dp(int[][] dp, string s, int l, int r)
        {
            if (l > r) return 0;
            if (l == r) return 1;
            if (dp[l] == null) 
                dp[l] = new int[dp.Length];

            if (dp[l][r] == 0)
            {
                if (s[l] == s[r])
                    dp[l][r] = Dp(dp, s, l + 1, r - 1) + 2;
                else
                    dp[l][r] = Math.Max(Dp(dp, s, l + 1, r), Dp(dp, s, l, r - 1));

                dp[l][r]++;
            }

            return dp[l][r] - 1;
        }
    }
}
