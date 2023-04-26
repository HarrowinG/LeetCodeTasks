namespace LeetCodeTasks._1143LongestCommonSubsequence
{
    public class LongestCommonSubsequenceClass
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            return TopDown(text1, text2);
            //return BottomUp(text1, text2);
        }

        private int TopDown(string text1, string text2)
        {
            var memo = new int[text1.Length + 1][];
            for (int i = 0; i < memo.Length; i++) memo[i] = new int[text2.Length + 1];
            return Dfs(text1, 0, text2, 0, memo);
        }

        private int Dfs(string text1, int id1, string text2, int id2, int[][] memo)
        {
            if (id1 == text1.Length || id2 == text2.Length) return 0;

            if (memo[id1][id2] == 0)
            {
                if (text1[id1] == text2[id2]) memo[id1][id2] += Dfs(text1, id1 + 1, text2, id2 + 1, memo) + 1;
                else
                {
                    memo[id1][id2] = Math.Max(Dfs(text1, id1 + 1, text2, id2, memo), Dfs(text1, id1, text2, id2 + 1, memo));
                }

                memo[id1][id2]++;
            }

            return memo[id1][id2] - 1;
        }

        private int BottomUp(string text1, string text2)
        {
            var row = new int[text2.Length + 1];
            for (var i = text1.Length - 1; i>= 0; i--)
            {
                var current = new int[text2.Length + 1];
                for (var j = text2.Length - 1; j >= 0; j--)
                {
                    if (text1[i] == text2[j]) current[j] = row[j + 1] + 1;
                    else current[j] = Math.Max(current[j + 1], row[j]);
                }

                row = current;
            }

            return row[0];
        }
    }
}
