namespace LeetCodeTasks._1857LargestColorValueinaDirectedGraph
{
    public class LargestColorValueinaDirectedGraph
    {
        public int LargestPathValue(string colors, int[][] edges)
        {
            var max = -1;
            var graph = new Dictionary<int, List<int>>();
            foreach (var edge in edges)
            {
                graph[edge[0]] = graph.GetValueOrDefault(edge[0], new List<int>());
                graph[edge[0]].Add(edge[1]);
            }

            var dp = new int[colors.Length][];
            var currentRun = new HashSet<int>();
            for (var i = 0; i < colors.Length; i++)
            {
                var result = Dfs(dp, graph, colors, i, currentRun);
                if (result == -1) return -1;

                max = Math.Max(max, result);
            }

            return max;
        }

        private int Dfs(int[][] dp, Dictionary<int, List<int>> graph, string colors, int vertex, HashSet<int> currentRun)
        {
            if (currentRun.Contains(vertex)) return -1;

            var colorId = colors[vertex] - 'a';
            if (dp[vertex] != null) return dp[vertex][colorId];

            dp[vertex] = new int[26];

            if (graph.ContainsKey(vertex))
            {
                currentRun.Add(vertex);
                foreach (var next in graph[vertex])
                {
                    if (Dfs(dp, graph, colors, next, currentRun) == -1) return -1;

                    for (var i = 0; i < 26; i++)
                        dp[vertex][i] = Math.Max(dp[vertex][i], dp[next][i]);
                }
                currentRun.Remove(vertex);
            }

            dp[vertex][colorId]++;
            return dp[vertex][colorId];
        }
    }
}
