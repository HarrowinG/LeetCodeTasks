namespace LeetCodeTasks._1376TimeNeededtoInformAllEmployees
{
    public class TimeNeededtoInformAllEmployees
    {
        public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
        {
            var graph = new Dictionary<int, List<int>>();
            for (var i = 0; i < manager.Length; i++)
            {
                if (manager[i] == -1) continue;

                graph[manager[i]] = graph.GetValueOrDefault(manager[i], new List<int>());
                graph[manager[i]].Add(i);
            }

            return Dfs(graph, informTime, headID);
        }

        private int Dfs(Dictionary<int, List<int>> graph, int[] informTime, int head)
        {
            if (!graph.ContainsKey(head)) return 0;

            var max = 0;
            foreach (var sub in graph[head])
                max = Math.Max(max, Dfs(graph, informTime, sub));

            return informTime[head] + max;
        }
    }
}
