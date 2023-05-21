namespace LeetCodeTasks._934ShortestBridge
{
    public class ShortestBridgeClass
    {
        readonly HashSet<int> _border = new();
        public int ShortestBridge(int[][] grid)
        {
            FillFirstIsland(grid);

            var queue = new Queue<int>();
            foreach (var border in _border)
                queue.Enqueue(border);

            var bridge = 0;
            while (queue.Count > 0)
            {
                var n = queue.Count;
                for (var i = 0; i < n; i++)
                {
                    var item = queue.Dequeue();
                    var c = item % grid.Length;
                    var r = (item - c) / grid.Length;

                    foreach (var neighbor in GetNeighbors(grid, r, c))
                    {
                        if (grid[neighbor.r][neighbor.c] == 1) return bridge;
                        if (grid[neighbor.r][neighbor.c] == 2) continue;

                        grid[neighbor.r][neighbor.c] = 2;
                        queue.Enqueue(neighbor.r * grid.Length + neighbor.c);
                    }
                }

                bridge++;
            }

            return bridge;
        }

        private IEnumerable<(int r, int c)> GetNeighbors(int[][] grid, int x, int y)
        {
            if (x + 1 < grid.Length) yield return (x + 1, y);
            if (x - 1 >= 0) yield return (x - 1, y);
            if (y + 1 < grid.Length) yield return (x, y + 1);
            if (y - 1 >= 0) yield return (x, y - 1);
        }

        private void FillFirstIsland(int[][] grid)
        {
            for (var i = 0; i < grid.Length; i++)
                for (var j = 0; j < grid[i].Length; j++)
                    if (grid[i][j] == 1)
                    {
                        Dfs(grid, i, j);
                        return;
                    }
        }

        private bool Dfs(int[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid.Length) return false;
            if (grid[i][j] == 0) return true;
            if (grid[i][j] == 2) return false;

            grid[i][j] = 2;
            if (Dfs(grid, i + 1, j) | Dfs(grid, i - 1, j)
                | Dfs(grid, i, j + 1) | Dfs(grid, i, j - 1))
            {
                _border.Add(i * grid.Length + j);
            }

            return false;
        }
    }
}
