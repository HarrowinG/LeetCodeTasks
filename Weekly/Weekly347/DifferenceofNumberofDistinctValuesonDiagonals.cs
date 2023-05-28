using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly347
{
    public class DifferenceofNumberofDistinctValuesonDiagonals
    {
        public int[][] DifferenceOfDistinctValues(int[][] grid)
        {
            var result = new int[grid.Length][];
            for (var i = 0; i < grid.Length; i++)
            {
                result[i] = new int[grid[i].Length];
                for (var j = 0; j < grid[i].Length; j++)
                {
                    var set = new HashSet<int>();
                    var r = i + 1; var c = j + 1;
                    while (r < grid.Length && c < grid[i].Length)
                    {
                        set.Add(grid[r][c]);
                        r++;
                        c++;
                    }
                    var bottom = set.Count;
                    set.Clear();
                    r = i - 1; c = j - 1;
                    while (r >= 0 && c >= 0)
                    {
                        set.Add(grid[r][c]);
                        r--;
                        c--;
                    }
                    var top = set.Count;

                    result[i][j] = Math.Abs(top - bottom);
                }
            }

            return result;
        }
    }
}
