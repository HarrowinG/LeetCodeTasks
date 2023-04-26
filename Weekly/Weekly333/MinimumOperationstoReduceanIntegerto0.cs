using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly333
{
    public class MinimumOperationstoReduceanIntegerto0
    {
        public int MinOperations(int n)
        {
            if (n == 1 || n == 0) return 1;

            var high = 1;
            while (high < n)
            {
                high *= 2;
            }
            if (high == n) return 1;

            var low = high / 2;

            var up = high - n;
            var down = n - low;

            return MinOperations(Math.Min(up, down)) + 1;
        }
    }
}
