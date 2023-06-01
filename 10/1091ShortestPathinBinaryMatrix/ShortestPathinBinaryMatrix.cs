namespace LeetCodeTasks._1091ShortestPathinBinaryMatrix
{
    public class ShortestPathinBinaryMatrix
    {
        static readonly int[] RowDeltas =    new []{ 1,1, 1, 0,-1,-1,-1,0 };
        static readonly int[] ColumnDeltas = new []{ 1,0,-1,-1,-1, 0, 1,1 };

        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            var n = grid.Length;
            if (grid[0][0] == 1 || grid[n - 1][n - 1] == 1) return -1;

            var queue = new Queue<int>();
            queue.Enqueue(0);
            grid[0][0] = 1;
            while (queue.Count > 0)
            {
                var point = queue.Dequeue();
                var y = point % n;
                var x = (point - y) / n;
                for (var i = 0; i < RowDeltas.Length; i++)
                {
                    var r = x + RowDeltas[i];
                    var c = y + ColumnDeltas[i];
                    if (r < 0 || r >= grid.Length || c < 0 || c >= grid.Length || grid[r][c] != 0) continue;

                    grid[r][c] = grid[x][y] + 1;
                    queue.Enqueue(r * n + c);
                }
            }

            return grid[n - 1][n - 1] == 0 ? -1 : grid[n - 1][n - 1];
        }
    }
}
