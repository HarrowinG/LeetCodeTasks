using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly344
{
    public class NumberofAdjacentElementsWiththeSameColor
    {
        public int[] ColorTheArray(int n, int[][] queries)
        {
            var result = new int[queries.Length];
            var colors = new int[n];
            var count = 0;
            for (var i = 0; i < queries.Length; i++)
            {
                var pos = queries[i][0];
                var color = queries[i][1];
                if (pos - 1 >= 0 && colors[pos] == colors[pos - 1] && colors[pos] != 0) count--;
                if (pos + 1 < n && colors[pos] == colors[pos + 1] && colors[pos] != 0) count--;

                colors[pos] = color;

                if (pos - 1 >= 0 && colors[pos] == colors[pos - 1] && colors[pos] != 0) count++;
                if (pos + 1 < n && colors[pos] == colors[pos + 1] && colors[pos] != 0) count++;

                result[i] = count;
            }

            return result;
        }
    }
}
