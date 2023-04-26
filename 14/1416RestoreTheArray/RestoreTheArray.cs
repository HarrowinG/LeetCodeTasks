namespace LeetCodeTasks._1416RestoreTheArray
{
    public class RestoreTheArray
    {
        public int NumberOfArrays(string s, int k)
        {
            //return TopDown(s, k);
            return BottomUp(s, k);
        }

        private int BottomUp(string s, int k)
        {
            var modulo = (int)1e9 + 7;
            var dp = new int[s.Length + 1];
            dp[s.Length] = 1;
            for (var i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '0') continue;

                long num = 0;
                for (var j = i; j < s.Length; j++)
                {
                    num = num * 10 + (s[j] - '0');
                    if (num > k) break;

                    dp[i] = (dp[i] + dp[j + 1]) % modulo;
                }
            }

            return dp[0];
        }

        private int TopDown(string s, int k)
        {
            var modulo = (int)1e9 + 7;
            var dp = new int[s.Length];
            Array.Fill(dp, int.MinValue);
            return Dfs(s, k, 0, dp, modulo);
        }

        private int Dfs(string s, int k, int i, int[] dp, int modulo)
        {
            if (i == s.Length) return 1;
            if (s[i] == '0') return 0;

            if (dp[i] == int.MinValue)
            {
                dp[i] = 0;
                long num = 0;
                for (var j = i; j < s.Length; j++)
                {
                    num = num * 10 + (s[j] - '0');
                    if (num > k) break;

                    dp[i] = (dp[i] + Dfs(s, k, j + 1, dp, modulo)) % modulo;
                }
            }

            return dp[i];
        }
    }
}
