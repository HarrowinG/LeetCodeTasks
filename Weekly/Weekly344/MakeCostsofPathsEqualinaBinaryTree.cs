using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly344
{
    public class MakeCostsofPathsEqualinaBinaryTree
    {
        public int MinIncrements(int n, int[] cost)
        {
            return Dfs(n, cost, 0).Diff;
        }

        private (int Max, int Diff) Dfs(int n, int[] cost, int i)
        {
            var l = 2 * i + 1;
            var r = 2 * i + 2;
            if (l >= n) return (cost[i], 0);

            var left = Dfs(n, cost, l);
            var right = Dfs(n, cost, r);
            left.Max += cost[i];
            right.Max += cost[i];

            var diff = Math.Abs(left.Max - right.Max);
            return (Math.Max(left.Max, right.Max), left.Diff + right.Diff + diff);
        }
    }
}
