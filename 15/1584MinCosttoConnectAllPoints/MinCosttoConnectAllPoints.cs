namespace LeetCodeTasks._1584MinCosttoConnectAllPoints
{
    public class MinCosttoConnectAllPoints
    {
        public int MinCostConnectPoints(int[][] points)
        {
            var cost = 0;
            var set = new HashSet<int>();
            var graph = new Dictionary<int, List<(int point, int weight)>>();

            for (var i = 0; i < points.Length; i++)
            {
                graph[i] = graph.GetValueOrDefault(i, new List<(int point, int weight)>());
                for (var j = i + 1; j < points.Length; j++)
                {
                    graph[j] = graph.GetValueOrDefault(j, new List<(int point, int weight)>());
                    var weight = Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]);
                    graph[j].Add((i, weight));
                    graph[i].Add((j, weight));
                }
            }

            var queue = new PriorityQueue<(int point, int weight), int>();
            queue.Enqueue((0, 0), 0);
            while (queue.Count > 0)
            {
                if (set.Count == points.Length) break;
                var item = queue.Dequeue();
                if (set.Contains(item.point)) continue;

                set.Add(item.point);
                cost += item.weight;
                foreach (var next in graph[item.point])
                {
                    if (set.Contains(next.point)) continue;

                    queue.Enqueue(next, next.weight);
                }
            }

            return cost;
        }
    }
}
