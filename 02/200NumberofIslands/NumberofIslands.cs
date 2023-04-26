namespace LeetCodeTasks._200NumberofIslands
{
    public class NumberofIslands
    {
        public int NumIslands(char[][] grid)
        {
            var verified = new bool[grid.Length, grid[0].Length];
            var islands = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (verified[i, j] || grid[i][j] == '0') continue;

                    Bfs(grid, verified, i, j);
                    islands++;
                }
            }

            return islands;
        }

        private void Bfs(char[][] grid, bool[,] verified, int x, int y)
        {
            var queue = new Queue<(int x, int y)>();
            queue.Enqueue((x, y));
            verified[x, y] = true;
            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                foreach (var next in GetNeighbours(grid, item.x, item.y))
                {
                    if (verified[next.x, next.y] || grid[next.x][next.y] == '0') continue;

                    queue.Enqueue(next);
                    verified[next.x, next.y] = true;
                }
            }
        }

        private static int[] _rowDeltas = { 0, 1, 0, -1 };
        private static int[] _colDeltas = { 1, 0, -1, 0 };
        private IEnumerable<(int x, int y)> GetNeighbours(char[][] grid, int x, int y)
        {
            for (var i = 0; i < _rowDeltas.Length; i++)
            {
                var r = x + _rowDeltas[i];
                var c = y + _colDeltas[i];
                if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length) continue;

                yield return (r, c);
            }
        }
    }
}
