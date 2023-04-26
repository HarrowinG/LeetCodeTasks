using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly341
{
    public class RowWithMaximumOnes
    {
        public int[] RowAndMaximumOnes(int[][] mat)
        {
            var res = new int[2];
            for (var i = 0; i < mat.Length; i++)
            {
                var count = 0;
                for (var j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1) count++;
                }

                if (count > res[1])
                {
                    res[0] = i;
                    res[1] = count;
                }
            }

            return res;
        }
    }
}
