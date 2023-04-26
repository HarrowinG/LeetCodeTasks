namespace LeetCodeTasks._1254NumberofClosedIslands
{
    public class NumberofClosedIslands
    {
        public int ClosedIsland(int[][] grid)
        {
            //return Dfs(grid);
            return Bfs(grid);
        }

        private int Dfs(int[][] grid)
        {
            var result = 0;
            for (var i = 0; i < grid.Length; i++)
                for (var j = 0; j < grid[i].Length; j++)
                    if (grid[i][j] == 0)
                        result += ClosedDfs(grid, i, j);

            return result;
        }

        private int ClosedDfs(int[][] grid, int x, int y)
        {
            if (x < 0 || x>= grid.Length || y < 0 || y >= grid[0].Length) return 0;

            if (grid[x][y] > 0) return 1;

            grid[x][y] = 2;

            return ClosedDfs(grid, x - 1, y) * ClosedDfs(grid, x + 1, y) * ClosedDfs(grid, x, y - 1) * ClosedDfs(grid, x, y + 1);
        }

        private int Bfs(int[][] grid)
        {
            var result = 0;
            var set = new HashSet<int>();
            var rowDeltas =    new[] { 0, 1, 0, -1 };
            var columnDeltas = new[] { 1, 0, -1, 0 };

            for (var i = 0; i < grid.Length; i++)
                for (var j = 0; j < grid[i].Length; j++)
                    if (grid[i][j] == 0 && !set.Contains(i * grid[0].Length + j))
                        result += ClosedBfs(grid, i, j, rowDeltas, columnDeltas, set);

            return result;
        }

        private int ClosedBfs(int[][] grid, int x, int y, int[] rowDeltas, int[] columnDeltas, HashSet<int> set)
        {
            var result = 1;
            var queue = new Queue<int>();
            set.Add(x * grid[0].Length + y);
            queue.Enqueue(x * grid[0].Length + y);
            while (queue.Count > 0)
            {
                x = queue.Peek() / grid[0].Length;
                y = queue.Dequeue() % grid[0].Length;
                for (var i = 0; i < rowDeltas.Length; i++)
                {
                    var r = x + rowDeltas[i];
                    var c = y + columnDeltas[i];

                    if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length)
                        result = 0;
                    else if (grid[r][c] == 0)
                    {
                        var item = r * grid[0].Length + c;
                        if (set.Contains(item)) continue;

                        queue.Enqueue(item);
                        set.Add(item);
                    }
                }
            }

            return result;
        }
    }
}
