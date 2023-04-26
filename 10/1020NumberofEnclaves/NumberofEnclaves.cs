namespace LeetCodeTasks._1020NumberofEnclaves
{
    public class NumberofEnclaves
    {
        public int NumEnclaves(int[][] grid)
        {
            return Dfs(grid);
            //return Bfs(grid);
        }

        private int Dfs(int[][] grid)
        {
            var result = 0;
            var m = grid.Length;
            var n = grid[0].Length;
            for (var i = 0; i < m; i++)
            {
                if (grid[i][0] == 1) Dfs(grid, i, 0);
                if (grid[i][n - 1] == 1) Dfs(grid, i, n - 1);
            }
            for (var j = 0; j < n; j++)
            {
                if (grid[0][j] == 1) Dfs(grid, 0, j);
                if (grid[m - 1][j] == 1) Dfs(grid, m - 1, j);
            }

            for (var i = 1; i < m - 1; i++)
                for (var j = 1; j < n - 1; j++)
                    if (grid[i][j] == 1)
                        result += Dfs(grid, i, j);

            return result;
        }

        private int Dfs(int[][] grid, int x, int y)
        {
            if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length) return 0;
            if (grid[x][y] != 1) return 0;

            grid[x][y] = 2;

            return Dfs(grid, x + 1, y) + Dfs(grid, x - 1, y) + Dfs(grid, x, y + 1) + Dfs(grid, x, y - 1) + 1;
        }

        private int Bfs(int[][] grid)
        {
            var result = 0;
            var m = grid.Length;
            var n = grid[0].Length;
            var rowDeltas =    new[] { 0, 1, 0, -1 };
            var columnDeltas = new[] { 1, 0, -1, 0 };
            for (var i = 0; i < m; i++)
            {
                if (grid[i][0] == 1) Bfs(grid, i, 0, rowDeltas, columnDeltas);
                if (grid[i][n - 1] == 1) Bfs(grid, i, n - 1, rowDeltas, columnDeltas);
            }
            for (var j = 0; j < n; j++)
            {
                if (grid[0][j] == 1) Bfs(grid, 0, j, rowDeltas, columnDeltas);
                if (grid[m - 1][j] == 1) Bfs(grid, m - 1, j, rowDeltas, columnDeltas);
            }

            for (var i = 1; i < m - 1; i++)
                for (var j = 1; j < n - 1; j++)
                    if (grid[i][j] == 1)
                        result += Bfs(grid, i, j, rowDeltas, columnDeltas);

            return result;
        }

        private int Bfs(int[][] grid, int x, int y, int[] rowDeltas, int[] columnDeltas)
        {
            var sum = 0;
            var n = grid[0].Length;
            var set = new HashSet<int>();
            var queue = new Queue<int>();
            set.Add(x * n + y);
            queue.Enqueue(x * n + y);
            while (queue.Count > 0)
            {
                sum++;
                x = queue.Peek() / n;
                y = queue.Dequeue() % n;
                grid[x][y] = 2;
                for (var i = 0; i < rowDeltas.Length; i++)
                {
                    var r = x + rowDeltas[i];
                    var c = y + columnDeltas[i];
                    if (r < 0 || r >= grid.Length || c < 0 || c >= n) continue;
                    if (grid[r][c] != 1) continue;

                    var item = r * n + c;
                    if (set.Contains(item)) continue;

                    set.Add(item);
                    queue.Enqueue(item);
                }
            }

            return sum;
        }
    }
}
