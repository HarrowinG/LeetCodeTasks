using System;
using System.Collections.Generic;

namespace LeetCodeTasks._2359FindClosestNodetoGivenTwoNodes
{
    public class FindClosestNodetoGivenTwoNodes
    {
        public int ClosestMeetingNode(int[] edges, int node1, int node2)
        {
            int n = edges.Length;
            int[] node1Distances = new int[n];
            int[] node2Distances = new int[n];
            Array.Fill(node1Distances, int.MaxValue);
            Array.Fill(node2Distances, int.MaxValue);

            //Bfs(node1, node1Distances, edges);
            //Bfs(node2, node2Distances, edges);
            Dfs(node1, node1Distances, edges, 0);
            Dfs(node2, node2Distances, edges, 0);

            int res = int.MaxValue, node = -1;
            for (int i = 0; i < n; i++)
            {
                if (node1Distances[i] == int.MaxValue || node2Distances[i] == int.MaxValue) continue;
                int maxPathToEdge = Math.Max(node1Distances[i], node2Distances[i]);
                if (res > maxPathToEdge)
                {
                    node = i;
                    res = maxPathToEdge;
                }
            }
            return node;
        }

        private void Bfs(int src, int[] dist, int[] edge)
        {
            var queue = new Queue<int>();
            queue.Enqueue(src);
            dist[src] = 0;
            while (queue.Count > 0)
            {
                int item = queue.Dequeue();
                if (edge[item] == -1 || dist[edge[item]] != int.MaxValue) continue;

                queue.Enqueue(edge[item]);
                dist[edge[item]] = dist[item] + 1;
            }
        }

        //only one connected edge so dfs here is better and bfs actually is dfs
        private void Dfs(int src, int[] dist, int[] edge, int steps)
        {
            while (src != -1 && dist[src] == int.MaxValue)
            {
                dist[src] = steps++;
                src = edge[src];
            }
        }
    }
}
