namespace LeetCodeTasks._785IsGraphBipartite
{
    public class IsGraphBipartite
    {
        public bool IsBipartite(int[][] graph)
        {
            var colors = new int[graph.Length];
            for (var i = 0; i < graph.Length; i++)
                if (colors[i] == 0 && !Dfs(graph, colors, i, 1)) 
                    return false;

            return true;
        }

        private bool Dfs(int[][] graph, int[] colors, int i, int color)
        {
            colors[i] = color;
            foreach (var next in graph[i])
            {
                if (colors[next] == -color) continue;
                if (colors[next] == color || !Dfs(graph, colors, next, -color)) return false;
            }

            return true;
        }
    }
}
