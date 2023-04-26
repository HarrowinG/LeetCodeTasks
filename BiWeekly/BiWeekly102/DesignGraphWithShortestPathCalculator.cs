using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly102
{
    public class Graph
    {
        Dictionary<int, List<(int To, int Cost)>> _graph = new();
        Dictionary<(int Node1, int Node2), int> _cache = new(); //todo broken with cache

        public Graph(int n, int[][] edges)
        {
            foreach (var edge in edges)
            {
                AddEdge(edge);
            }
        }

        public void AddEdge(int[] edge)
        {
            _graph[edge[0]] = _graph.GetValueOrDefault(edge[0], new List<(int To, int Cost)>());
            _graph[edge[0]].Add((edge[1], edge[2]));

            _cache.Clear();
        }

        public int ShortestPath(int node1, int node2)
        {
            if (node1 == node2) return 0;
            if (!_graph.ContainsKey(node1)) return -1;

            var queue = new PriorityQueue<(int Node, int Cost), int>();
            foreach (var (To, Cost) in _graph[node1])
            {
                queue.Enqueue((To, Cost), Cost);
            }

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                if (item.Node == node2)
                {
                    _cache[(node1, node2)] = item.Cost;
                    return item.Cost;
                }

                var key = (node1, item.Node);
                _cache[key] = Math.Min(item.Cost, _cache.ContainsKey(key) ? _cache[key] : int.MaxValue);
                if (!_graph.ContainsKey(item.Node)) continue;

                foreach (var (To, Cost) in _graph[item.Node])
                {
                    key = (To, node2);
                    if (_cache.ContainsKey(key))
                        queue.Enqueue((node2, item.Cost + _cache[key]), item.Cost + _cache[key]);
                    else
                        queue.Enqueue((To, item.Cost + Cost), item.Cost + Cost);
                }
            }

            return -1;
        }
    }
}
