using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly101
{
    public class ShortestCycleinaGraph
    {
        public int FindShortestCycle(int n, int[][] edges)
        {
            var result = int.MaxValue;
            var visited = new HashSet<int>();
            var graph = new Dictionary<int, List<int>>();
            foreach (var edge in edges)
            {
                graph[edge[0]] = graph.GetValueOrDefault(edge[0], new List<int>());
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]] = graph.GetValueOrDefault(edge[1], new List<int>());
                graph[edge[1]].Add(edge[0]);
            }

            var steps = new int[n];
            var currentRun = new HashSet<int>();
            foreach (var item in graph)
            {
                if (visited.Contains(item.Key)) continue;

                result = Math.Min(result, FindShortest(item.Key, item.Key, 1, graph, steps, visited, currentRun));
            }

            return result == int.MaxValue ? -1 : result;
        }

        private int FindShortest(int vertex, int parent, int step, Dictionary<int, List<int>> graph, 
            int[] steps, HashSet<int> visited, HashSet<int> currentRun)
        {
            visited.Add(vertex);

            if (steps[vertex] != 0)
            {
                if (currentRun.Contains(vertex))
                    return step - steps[vertex];

                if (step >= steps[vertex])
                    return int.MaxValue;
            }

            currentRun.Add(vertex);
            steps[vertex] = step;

            var min = int.MaxValue;
            foreach (var next in graph[vertex])
            {
                if (next == parent) continue;

                min = Math.Min(min, FindShortest(next, vertex, step + 1, graph, steps, visited, currentRun));
            }

            currentRun.Remove(vertex);
            return min;
        }
    }
}
