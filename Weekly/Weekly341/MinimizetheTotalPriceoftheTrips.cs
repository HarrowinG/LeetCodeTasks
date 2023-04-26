using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly341
{
    public class MinimizetheTotalPriceoftheTrips
    {
        public int MinimumTotalPrice(int n, int[][] edges, int[] price, int[][] trips)
        {
            var tripPathes = new List<int>[trips.Length];
            var graph = new Dictionary<int, HashSet<int>>();
            foreach (var edge in edges)
            {
                graph[edge[0]] = graph.GetValueOrDefault(edge[0], new HashSet<int>());
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]] = graph.GetValueOrDefault(edge[1], new HashSet<int>());
                graph[edge[1]].Add(edge[0]);
            }

            for (var i = 0; i < trips.Length; i++)
            {
                var trip = trips[i];
                var end = trip[1];
                var visited = new HashSet<int>();
                var queue = new Queue<(int node, List<int> path)>();
                queue.Enqueue((trip[0], new List<int> { trip[0] }));
                while (queue.Count > 0)
                {
                    var item = queue.Dequeue();
                    if (item.node == end)
                    {
                        tripPathes[i] = new List<int>(item.path);
                        break;
                    }

                    foreach (var node in graph[item.node])
                    {
                        if (visited.Contains(node)) continue;

                        visited.Add(node);
                        var path = new List<int>(item.path);
                        path.Add(node);
                        queue.Enqueue((node, path));
                    }
                }
            }

            //dp on tripPathes to find minimum cost and halve nodes


            return 0;
        }
    }
}
