using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly343
{
    public class MinimumCostofaPathWithSpecialRoads
    {
        //wrong
        public int MinimumCost(int[] start, int[] target, int[][] specialRoads)
        {
            var maxDimmension = Math.Max(target[0], target[1]);
            var dp = new int[maxDimmension + 1][];
            for (var i = 0; i < dp.Length; i++)
                dp[i] = new int[maxDimmension + 1];

            var specials = new Dictionary<(int, int), (int x, int y, int cost)>();
            foreach (var road in specialRoads)
                specials[(road[2], road[3])] = (road[0], road[1], road[4]);

            int x = start[0], y = start[1], targetX = target[0], targetY = target[1];
            dp[x][y] = 1;
            return Dfs(specials, x, y, dp, targetX, targetY);
        }

        private int Dfs(
            Dictionary<(int, int), (int x, int y, int cost)> specials, int startX, int startY, int[][] dp, int x, int y)
        {
            if (x < startX || y < startY) return int.MaxValue;

            if (dp[x][y] == 0)
            {
                var key = (x, y);
                var special = int.MaxValue;
                if (specials.ContainsKey(key))
                    special = specials[key].cost + Dfs(specials, startX, startY, dp, specials[key].x, specials[key].y);

                dp[x][y] = Math.Min(special, Math.Min(Dfs(specials, startX, startY, dp, x - 1, y),
                                                      Dfs(specials, startX, startY, dp, x, y - 1)) + 1);

                dp[x][y]++;
            }

            return dp[x][y] - 1;
        }

        private int Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x2 - x1) + Math.Abs(y2 - y1);
        }
    }
}
