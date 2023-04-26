using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly317
{
    public class _6220AverageValueofEvenNumbersThatAreDivisiblebyThree
    {
        public int AverageValue(int[] nums)
        {
            var n = 0;
            var sum = 0;
            foreach (var num in nums)
            {
                if (num % 2 == 0 && num % 3 == 0)
                {
                    sum += num;
                    n++;
                }
            }

            return n == 0 ? 0 : sum / n;
        }
    }
}
