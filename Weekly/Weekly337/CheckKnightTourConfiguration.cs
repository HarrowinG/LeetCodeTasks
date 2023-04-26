using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly337
{
    public class CheckKnightTourConfiguration
    {
        public bool CheckValidGrid(int[][] grid)
        {
            var rowDeltas = new int[] { -2, -1, 1, 2, 2, 1, -1, -2 };
            var colDeltas = new int[] { 1, 2, 2, 1, -1, -2, -2, -1 };
            var n = grid.Length * grid.Length - 1;
            var step = 1;
            var x = 0;
            var y = 0;
            while (n > 0)
            {
                var found = false;
                foreach (var neighbor in GetNeighbors(grid, rowDeltas, colDeltas, x, y))
                {
                    if (grid[neighbor.r][neighbor.c] == step)
                    {
                        x = neighbor.r;
                        y = neighbor.c;
                        step++;
                        found = true;
                    }
                }
                n--;

                if (!found) return false;
            }

            return true;
        }

        private IEnumerable<(int r, int c)> GetNeighbors(int[][] grid, int[] rowDeltas, int[] colDeltas, int x, int y)
        {
            for (var i = 0; i < rowDeltas.Length; i++)
            {
                var r = x + rowDeltas[i];
                var c = y + colDeltas[i];
                if (r < 0 || r >= grid.Length || c < 0 || c >= grid.Length) continue;

                yield return (r, c);
            }
        }
    }
}
