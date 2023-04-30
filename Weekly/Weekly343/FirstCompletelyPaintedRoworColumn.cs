using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly343
{
    public class FirstCompletelyPaintedRoworColumn
    {
        public int FirstCompleteIndex(int[] arr, int[][] mat)
        {
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < arr.Length; i++)
                dict[arr[i]] = i;

            var min = int.MaxValue;
            for (var i = 0; i < mat.Length; i++)
            {
                var maxRow = dict[mat[i][0]];
                for (var j = 1; j < mat[i].Length; j++)
                {
                    maxRow = Math.Max(maxRow, dict[mat[i][j]]);
                }
                min = Math.Min(min, maxRow);
            }

            for (var i = 0; i < mat[0].Length; i++)
            {
                var maxCol = dict[mat[0][i]];
                for (var j = 1; j < mat.Length; j++)
                {
                    maxCol = Math.Max(maxCol, dict[mat[j][i]]);
                }
                min = Math.Min(min, maxCol);
            }

            return min;
        }
    }
}
