using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly102
{
    public class FindtheWidthofColumnsofaGrid
    {
        public int[] FindColumnWidth(int[][] grid)
        {
            var res = new int[grid[0].Length];
            for (var j = 0; j < grid[0].Length; j++)
            {
                for (var i = 0; i < grid.Length; i++)
                {
                    var num = grid[i][j];
                    var addition = num < 0 || num == 0 ? 1 : 0;
                    while (num != 0)
                    {
                        addition++;
                        num /= 10;
                    }

                    res[j] = Math.Max(res[j], addition);
                }
            }

            return res;
        }
    }
}
