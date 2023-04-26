namespace LeetCodeTasks._417PacificAtlanticWaterFlow
{
    public class PacificAtlanticWaterFlow
    {
        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            var result = new List<IList<int>>();
            var verified = new int[heights.Length, heights[0].Length];
            for (var i = 0; i < heights.Length; i++) Bfs(heights, verified, i, heights[0].Length - 1, result, 1);
            for (var i = 0; i < heights[0].Length; i++) Bfs(heights, verified, heights.Length - 1, i, result, 1);
            for (var i = 0; i < heights[0].Length; i++) Bfs(heights, verified, 0, i, result, 2);
            for (var i = 0; i < heights.Length; i++) Bfs(heights, verified, i, 0, result, 2);

            return result;
        }

        private void Bfs(int[][] heights, int[,] verified, int x, int y, IList<IList<int>> result, int ocean)
        {
            if (verified[x, y] == ocean) return;
            var queue = new Queue<(int x, int y)>();
            queue.Enqueue((x, y));
            if (verified[x, y] != 0)
            {
                result.Add(new List<int> { x, y });
            }
            verified[x, y] = ocean;

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                foreach (var next in GetNeighbors(heights, item.x, item.y))
                {
                    if (verified[next.x, next.y] == ocean) continue;

                    if (heights[next.x][next.y] >= heights[item.x][item.y])
                    {
                        queue.Enqueue(next);
                        if (verified[next.x, next.y] != 0 && verified[next.x, next.y] != ocean)
                        {
                            result.Add(new List<int> { next.x, next.y });
                        }
                        verified[next.x, next.y] = ocean;
                    }
                }
            }
        }

        private static readonly int[] _rowDeltas = { 0, 1, 0, -1 };
        private static readonly int[] _colDeltas = { 1, 0, -1, 0 };
        private IEnumerable<(int x, int y)> GetNeighbors(int[][] heights, int x, int y)
        {
            for (int i = 0; i < _rowDeltas.Length; i++)
            {
                var r = _rowDeltas[i] + x;
                var c = _colDeltas[i] + y;
                if (r < 0 || r >= heights.Length || c < 0 || c >= heights[0].Length) continue;

                yield return (r, c);
            }
        }
    }
}
