namespace LeetCodeTasks._139WordBreak
{
    public class WordBreakClass
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            var dp = new bool[s.Length + 1];
            dp[s.Length] = true;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                foreach (string word in wordDict)
                {
                    if (i + word.Length > s.Length) continue;

                    dp[i] = dp[i + word.Length] && Match(s, i, word);
                    if (dp[i]) break;
                }
            }

            return dp[0];
        }

        private bool Match(string s, int id, string word)
        {
            for (int i = 0; i < word.Length; i++)
                if (word[i] != s[id + i]) return false;

            return true;
        }
    }
}
