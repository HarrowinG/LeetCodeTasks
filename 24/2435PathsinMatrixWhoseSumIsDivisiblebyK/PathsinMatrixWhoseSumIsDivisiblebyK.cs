namespace LeetCodeTasks._2435PathsinMatrixWhoseSumIsDivisiblebyK
{
    public class PathsinMatrixWhoseSumIsDivisiblebyK
    {
        public int NumberOfPaths(int[][] grid, int k)
        {
            //return TopDown(grid, k);
            return BottomUp(grid, k);
        }

        private int BottomUp(int[][] grid, int k)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var row = new int[n + 1, k + 1];
            row[1, 0] = 1;
            for (int i = 0; i < m; i++)
            {
                var current = new int[n + 1, k + 1];
                for (int j = 0; j < n; j++)
                    for (int l = 0; l < k; l++)
                        current[j + 1, (l + grid[i][j]) % k] = (current[j, l] + row[j + 1, l]) % 1000000007;
                row = current;
            }
            return row[n, 0];
        }

        private int TopDown(int[][] grid, int k)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var dp = new int[m * n + 1, k + 1];
            return dfs(0, 0, 0);

            int dfs(int i, int j, int mod)
            {
                if (i >= m || j >= n)
                    return 0;
                if (i == m - 1 && j == n - 1)
                    return (mod + grid[i][j]) % k != 0 ? 0 : 1;
                if (dp[i * n + j, mod] == 0)
                    dp[i * n + j, mod] = (1 + dfs(i + 1, j, (mod + grid[i][j]) % k) +
                        dfs(i, j + 1, (mod + grid[i][j]) % k)) % 1000000007;
                return dp[i * n + j, mod] - 1;
            }
        }
    }
}
