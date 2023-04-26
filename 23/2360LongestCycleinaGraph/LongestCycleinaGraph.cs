using System;

namespace LeetCodeTasks._2360LongestCycleinaGraph
{
    public class LongestCycleinaGraph
    {
        public int LongestCycle(int[] edges)
        {
            int res = -1;
            var memo = new (int Distance, int Vertex)[edges.Length];
            Array.Fill(memo, (-1, -1));
            for (int i = 0; i < edges.Length; ++i)
                for (int j = i, dist = 0; j != -1; j = edges[j])
                {
                    var item = memo[j];
                    if (item.Distance == -1)
                        memo[j] = (dist++, i);
                    else
                    {
                        if (item.Vertex == i)
                            res = Math.Max(res, dist - item.Distance);
                        break;
                    }
                }
            return res;
        }

        public int LongestCycle1(int[] edges)
        {
            var steps = new int[edges.Length];
            var memo = new int[edges.Length];
            var max = -1;
            Array.Fill(steps, -1);

            for (var i = 0; i < steps.Length; i++)
            {
                max = Math.Max(max, Dfs(edges, steps, i, 0, memo));
            }

            return max;
        }

        private int Dfs(int[] edges, int[] steps, int vertex, int step, int[] memo)
        {
            if (memo[vertex] != 0) return memo[vertex];

            if (steps[vertex] != -1) return step - steps[vertex];
            steps[vertex] = step;

            if (edges[vertex] == -1)
            {
                steps[vertex] = -1;
                return -1;
            }

            var res = Dfs(edges, steps, edges[vertex], step + 1, memo);
            memo[vertex] = res;
            steps[vertex] = -1;
            return res;
        }
    }
}
