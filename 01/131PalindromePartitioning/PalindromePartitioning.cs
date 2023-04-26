namespace LeetCodeTasks._131PalindromePartitioning
{
    public class PalindromePartitioning
    {
        public IList<IList<string>> Partition(string s)
        {
            var result = new List<IList<string>>();
            Dfs(s, 0, new List<string>(), result);
            return result;
        }

        private void Dfs(string s, int i, IList<string> current, IList<IList<string>> result)
        {
            if (i >= s.Length)
            {
                result.Add(current.ToList());
                return;
            }

            for (var j = i; j < s.Length; j++)
            {
                if (IsPalindrom(s, i, j))
                {
                    current.Add(s.Substring(i, j - i + 1));
                    Dfs(s, j + 1, current, result);
                    current.RemoveAt(current.Count - 1);
                }
            }
        }

        private bool IsPalindrom(string s, int l, int r)
        {
            if (r >= s.Length || l < 0) return false;
            while (l < r)
            {
                if (s[l] != s[r]) return false;
                l++;
                r--;
            }

            return true;
        }
    }
}
