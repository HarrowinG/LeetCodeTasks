using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly342
{
    public class SumMultiples
    {
        public int SumOfMultiples(int n)
        {
            var three = 3;
            var five = 5;
            var seven = 7;

            var sum = 0;
            for (var i = 1; i <= n; i++)
            {
                if (i == three || i == five || i == seven)
                {
                    sum += i;

                    if (i == three) three += 3;
                    if (i == five) five += 5;
                    if (i == seven) seven += 7;
                }
            }

            return sum;
        }
    }
}
