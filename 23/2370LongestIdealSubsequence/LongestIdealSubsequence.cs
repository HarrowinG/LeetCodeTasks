namespace LeetCodeTasks._2370LongestIdealSubsequence
{
    public class LongestIdealSubsequence
    {
        public int LongestIdealString(string s, int k)
        {
            var max = 1;
            var dp = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                var a = s[i] - 'a';
                for (var b = Math.Max(0, a - k); b <= Math.Min(25, a + k); b++)
                {
                    dp[a] = Math.Max(dp[a], dp[b]);
                }
                
                max = Math.Max(max, ++dp[a]);
            }
            
            return max;
        }

        public int LongestIdealStringTLE(string s, int k)
        {
            var dp = new int[s.Length];
            dp[0] = 1;
            var max = 1;
            for (int i = 1; i < s.Length; i++)
            {
                dp[i] = 1;
                for (var j = 0; j < i; j++)
                {
                    if (Math.Abs(s[i] - s[j]) <= k)
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }

                max = Math.Max(max, dp[i]);
            }

            return max;
        }
    }
}
