namespace LeetCodeTasks._2368ReachableNodesWithRestrictions
{
    public class ReachableNodesWithRestrictions
    {
        public int ReachableNodes(int n, int[][] edges, int[] restricted)
        {
            var graph = new Dictionary<int, List<int>>();
            foreach (var edge in edges)
            {
                if (graph.ContainsKey(edge[0]))
                {
                    graph[edge[0]].Add(edge[1]);
                }
                else
                {
                    graph[edge[0]] = new List<int> { edge[1] };
                }

                if (graph.ContainsKey(edge[1]))
                {
                    graph[edge[1]].Add(edge[0]);
                }
                else
                {
                    graph[edge[1]] = new List<int> { edge[0] };
                }
            }

            var verified = new HashSet<int>();
            foreach (var item in restricted)
            {
                verified.Add(item);
            }

            var queue = new Queue<int>();
            queue.Enqueue(0);
            verified.Add(0);
            var count = 0;
            while (queue.Count > 0)
            {
                count++;
                var item = queue.Dequeue();

                if (graph.ContainsKey(item))
                {
                    foreach (var vertex in graph[item])
                    {
                        if (!verified.Contains(vertex))
                        {
                            queue.Enqueue(vertex);
                            verified.Add(vertex);
                        }
                    }
                }
            }

            return count;
        }
    }
}
