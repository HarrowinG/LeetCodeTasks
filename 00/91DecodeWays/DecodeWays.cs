namespace LeetCodeTasks._91DecodeWays
{
    public class DecodeWays
    {
        public int NumDecodings(string s)
        {
            //return TopDown(s);
            return BottomUp(s);
        }

        private int TopDown(string s)
        {
            var dp = new int[s.Length];
            return Dfs(s, 0, dp);
        }

        private int Dfs(string s, int i, int[] dp)
        {
            if (i == s.Length) return 1;
            if (s[i] == '0') return 0;

            if (dp[i] == 0)
            {
                dp[i] = Dfs(s, i + 1, dp);
                if (i + 1 < s.Length && CheckTwoLengthForm(s[i], s[i + 1]))
                {
                    dp[i] += Dfs(s, i + 2, dp);
                }
                dp[i]++;
            }

            return dp[i] - 1;
        }

        private int BottomUp(string s)
        {
            if (s[0] == '0') return 0;

            var dp = new int[] { 0, 1, 1 };
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (dp[1] == 0 && dp[1] == dp[2]) return 0;

                if (s[i] == '0') dp[0] = 0;
                else dp[0] = dp[1];

                if (i + 1 < s.Length && CheckTwoLengthForm(s[i], s[i + 1]))
                {
                    dp[0] += dp[2];
                }

                dp[2] = dp[1];
                dp[1] = dp[0];
            }

            return dp[1];
        }

        private bool CheckTwoLengthForm(char a, char b)
        {
            if (a == '1') return true;
            if (a == '2') return b >= '0' && b <= '6';
            return false;
        }
    }
}
