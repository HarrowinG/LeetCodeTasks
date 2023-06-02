namespace LeetCodeTasks._2101DetonatetheMaximumBombs
{
    public class DetonatetheMaximumBombs
    {
        public int MaximumDetonation(int[][] bombs)
        {
            var graph = new List<List<int>>();
            for (var i = 0; i < bombs.Length; i++)
                graph.Add(new List<int>());

            for (var i = 0; i < bombs.Length; i++)
            {
                long x1 = bombs[i][0]; long y1 = bombs[i][1]; long r1 = 1L * bombs[i][2] * bombs[i][2];
                for (var j = i + 1; j < bombs.Length; j++)
                {
                    long x2 = bombs[j][0]; long y2 = bombs[j][1]; long r2 = 1L * bombs[j][2] * bombs[j][2];
                    var x = x2 - x1;
                    var y = y2 - y1;
                    var delta = x * x + y * y;
                    if (delta <= r1) graph[i].Add(j);
                    if (delta <= r2) graph[j].Add(i);
                }
            }

            var result = 1;
            for (var i = 0; i < bombs.Length; i++)
                result = Math.Max(result, Bfs(graph, i));

            return result;
        }

        private int Bfs(List<List<int>> graph, int bomb)
        {
            var count = 1;
            var set = new HashSet<int> { bomb };
            var queue = new Queue<int>();
            queue.Enqueue(bomb);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                foreach(var next in graph[current])
                {
                    if (set.Contains(next)) continue;

                    set.Add(next);
                    queue.Enqueue(next);
                    count++;
                }
            }

            return count;
        }
    }
}
