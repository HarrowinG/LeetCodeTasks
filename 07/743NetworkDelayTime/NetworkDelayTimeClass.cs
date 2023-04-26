namespace LeetCodeTasks._743NetworkDelayTime
{
    public class NetworkDelayTimeClass
    {
        public int NetworkDelayTime(int[][] times, int n, int k)
        {
            var graph = new Dictionary<int, List<(int Vertex, int Weight)>>();
            foreach (var time in times)
            {
                graph[time[0]] = graph.GetValueOrDefault(time[0], new List<(int Vertex, int Weight)>());
                graph[time[0]].Add((time[1], time[2]));
            }

            var set = new HashSet<int>();
            var queue = new PriorityQueue<(int Vertex, int Weight), int>();
            queue.Enqueue((k, 0), 0);
            var max = 0;

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                if (set.Contains(item.Vertex)) continue;

                set.Add(item.Vertex);
                max = Math.Max(max, item.Weight);
                if (!graph.ContainsKey(item.Vertex)) continue;

                foreach (var next in graph[item.Vertex])
                {
                    if (set.Contains(next.Vertex)) continue;
                    var weightSum = next.Weight + item.Weight;
                    queue.Enqueue((next.Vertex, weightSum), weightSum);
                }
            }

            return set.Count == n ? max : -1;
        }
    }
}
