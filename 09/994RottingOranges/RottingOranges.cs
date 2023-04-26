namespace LeetCodeTasks._994RottingOranges
{
    public class RottingOranges
    {
        public int OrangesRotting(int[][] grid)
        {
            return Bfs(grid);
        }

        private int Bfs(int[][] grid)
        {
            var freshNum = 0;
            var queue = new Queue<(int x, int y)>();
            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 2) queue.Enqueue((i, j));
                    else if (grid[i][j] == 1) freshNum++;
                }

            if (freshNum == 0) return 0;

            var minutes = -1;
            while (queue.Count > 0)
            {
                var n = queue.Count;
                for (int i = 0; i < n; i++)
                {
                    var item = queue.Dequeue();
                    foreach (var next in GetNeighbors(grid, item.x, item.y))
                    {
                        if (grid[next.x][next.y] == 0 || grid[next.x][next.y] == 2) continue;

                        queue.Enqueue(next);
                        grid[next.x][next.y] = 2;
                        freshNum--;
                    }
                }

                minutes++;
            }

            return freshNum == 0 ? minutes : -1;
        }

        private static readonly int[] _rowDeltas = { 0, 1, 0, -1 };
        private static readonly int[] _colDeltas = { 1, 0, -1, 0 };
        private IEnumerable<(int x, int y)> GetNeighbors(int[][] grid, int x, int y)
        {
            for (int i = 0; i < _rowDeltas.Length; i++)
            {
                var r = _rowDeltas[i] + x;
                var c = _colDeltas[i] + y;
                if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length) continue;

                yield return (r, c);
            }
        }
    }
}
