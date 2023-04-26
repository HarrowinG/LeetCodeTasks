using static System.Net.Mime.MediaTypeNames;

namespace LeetCodeTasks._695MaxAreaofIsland
{
    public class MaxAreaofIslandClass
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            var count = 0;
            var verified = new bool[grid.Length, grid[0].Length];
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 0 || verified[i, j]) continue;

                    count = Math.Max(count, Bfs(grid, verified, i, j));
                }
            }

            return count;
        }

        private int Bfs(int[][] grid, bool[,] verified, int x, int y)
        {
            var count = 0;
            var queue = new Queue<(int x, int y)>();
            queue.Enqueue((x, y));
            verified[x, y] = true;
            while (queue.Count > 0)
            {
                count++;
                var item = queue.Dequeue();
                foreach (var next in GetNeighbors(grid, item.x, item.y))
                {
                    if (verified[next.x, next.y] || grid[next.x][next.y] == 0) continue;

                    verified[next.x, next.y] = true;
                    queue.Enqueue(next);
                }
            }

            return count;
        }

        private static int[] _rowDeltas = { 0, 1, 0, -1 };
        private static int[] _colDeltas = { 1, 0, -1, 0 };

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
