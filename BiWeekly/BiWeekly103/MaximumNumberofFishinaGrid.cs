using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly103
{
    public class MaximumNumberofFishinaGrid
    {
        public int FindMaxFish(int[][] grid)
        {
            var max = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0;  j < grid[i].Length; j++)
                {
                    if (grid[i][j] != 0)
                    {
                        max = Math.Max(max, Dfs(grid, i, j));
                    }
                }
            }

            return max;
        }

        private int Dfs(int[][] grid, int x, int y)
        {
            if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length) return 0;
            if (grid[x][y] == 0) return 0;

            var res = grid[x][y];
            grid[x][y] = 0;
            return res + Dfs(grid, x + 1, y) + Dfs(grid, x - 1, y) + Dfs(grid, x, y + 1) + Dfs(grid, x, y - 1);
        }
    }
}
