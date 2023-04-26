using System.Numerics;

namespace LeetCodeTasks._2397MaximumRowsCoveredbyColumns
{
    public class MaximumRowsCoveredbyColumns
    {
        public int MaximumRows(int[][] mat, int cols)
        {
            //return Bit(mat, cols);
            return Backtracking(mat, cols);
        }

        private int Backtracking(int[][] mat, int cols)
        {
            int m = mat.Length, n = mat[0].Length;
            var selected = new bool[n];

            return Dfs(mat, m, n, cols, 0, selected);
        }

        private int Dfs(int[][] mat, int m, int n, int cols, int idx, bool[] selected)
        {
            if (cols == 0 || idx == n)
            {
                int res = 0;
                int rows = 0;
                for (int i = 0; i < m; i++)
                {
                    int j;
                    for (j = 0; j < n; j++)
                    {
                        if (mat[i][j] == 1 && !selected[j]) break;
                    }
                    if (j == n) rows++;
                }
                res = Math.Max(res, rows);
                return res;
            }

            selected[idx] = true;
            var included = Dfs(mat, m, n, cols - 1, idx + 1, selected);
            selected[idx] = false;

            var excluded = Dfs(mat, m, n, cols, idx + 1, selected);
            return Math.Max(included, excluded);

        }

        private int Bit(int[][] mat, int cols)
        {
            int m = mat.Length, n = mat[0].Length, res = 0;
            for (int mask = (1 << cols) - 1; mask < (1 << n); mask++)
            {
                if (BitOperations.PopCount((uint)mask) != cols) continue;
                int rows = 0;
                for (int i = 0; i < m; i++)
                {
                    int j;
                    for (j = 0; j < n; ++j)
                        if (mat[i][j] == 1 && (mask & (1 << j)) == 0) break;
                    if (j == n) rows++;
                }
                res = Math.Max(res, rows);
            }
            return res;
        }
    }
}
