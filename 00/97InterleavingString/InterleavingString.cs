namespace LeetCodeTasks._97InterleavingString
{
    public class InterleavingString
    {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length) return false;

            //return TopDown(s1, s2, s3);
            return BottomUp(s1, s2, s3);
        }

        private bool BottomUp(string s1, string s2, string s3)
        {
            var row = new bool[s2.Length + 1];
            row[s2.Length] = true;
            for (var i = s2.Length - 1; i >= 0; i--)
                row[i] = s2[i] == s3[s1.Length + i] && row[i + 1];

            for (var i = s1.Length - 1; i >= 0; i--)
            {
                var current = new bool[s2.Length + 1];
                current[s2.Length] = s1[i] == s3[s2.Length + i] && row[s2.Length];

                for (var j = s2.Length - 1; j >= 0; j--)
                    current[j] = s1[i] == s3[i + j] && row[j]
                                  || s2[j] == s3[i + j] && current[j + 1];

                row = current;
            }

            return row[0];
        }

        private bool TopDown(string s1, string s2, string s3)
        {
            return Dfs(s1, s2, s3, 0, 0, new bool?[s1.Length + 1, s2.Length + 1]);
        }

        private bool Dfs(string s1, string s2, string s3, int i1, int i2, bool?[,] memo)
        {
            if (i1 + i2 == s3.Length) return true;

            if (memo[i1, i2] == null)
            {
                memo[i1, i2] = false;

                if (i1 < s1.Length && s1[i1] == s3[i1 + i2])
                    memo[i1, i2] = Dfs(s1, s2, s3, i1 + 1, i2, memo);

                if (!memo[i1, i2].Value && i2 < s2.Length && s2[i2] == s3[i1 + i2])
                    memo[i1, i2] = Dfs(s1, s2, s3, i1, i2 + 1, memo);
            }

            return memo[i1, i2].Value;
        }
    }
}
