using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly346
{
    public class ModifyGraphEdgeWeights
    {
        Dictionary<int, Dictionary<int, int>> _graph = new();
        public int[][] ModifiedGraphEdges(int n, int[][] edges, int source, int destination, int target)
        {
            foreach (var edge in edges)
            {
                var start = edge[0]; var end = edge[1]; var val = edge[2];
                _graph[start] = _graph.GetValueOrDefault(start, new Dictionary<int, int>());
                _graph[start][end] = val;
                _graph[end] = _graph.GetValueOrDefault(end, new Dictionary<int, int>());
                _graph[end][start] = val;
            }

            var visited = new HashSet<int>();
            var paths = new List<IList<int>>();
            Dfs(visited, new List<int> { source }, paths, source, destination);

            var unfinishedPaths = new List<(int, List<int>)>();
            foreach (var path in paths)
            {
                var sum = 0;
                var unfinished = new List<int>();
                for (var i = 1; i < path.Count; i++)
                {
                    var weight = _graph[path[i]][path[i - 1]];
                    if (weight != -1)
                        sum += weight;
                    else
                    {
                        unfinished.Add(path[i - 1]);
                        unfinished.Add(path[i]);
                    }
                }

                if (sum < target)
                    unfinishedPaths.Add((sum, unfinished));
            }

            //todo
            return new int[1][];
        }

        private void Dfs(HashSet<int> visited, IList<int> current, IList<IList<int>> paths, int vertex, int destination)
        {
            if (vertex == destination)
            {
                paths.Add(current.ToList());
                return;
            }

            visited.Add(vertex);
            foreach (var next in _graph[vertex].Keys)
            {
                if (visited.Contains(next)) continue;
                current.Add(next);
                Dfs(visited, current, paths, next, destination);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
