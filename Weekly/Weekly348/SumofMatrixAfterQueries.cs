using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly348
{
    public class SumofMatrixAfterQueries
    {
        public long MatrixSumQueries(int n, int[][] queries)
        {
            long result = 0;
            var rows = new HashSet<int>();
            var columns = new HashSet<int>();
            for (var i = queries.Length - 1; i >= 0; i--)
            {
                var query = queries[i];
                if (query[0] == 0)
                {
                    if (rows.Contains(query[1])) continue;

                    rows.Add(query[1]);
                    result += 1L * query[2] * (n - columns.Count);
                }
                else
                {
                    if (columns.Contains(query[1])) continue;

                    columns.Add(query[1]);
                    result += 1L * query[2] * (n - rows.Count);
                }
            }

            return result;
        }
    }
}
