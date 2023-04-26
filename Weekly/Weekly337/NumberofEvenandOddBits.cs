using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly337
{
    public class NumberofEvenandOddBits
    {
        public int[] EvenOddBit(int n)
        {
            var s = Convert.ToString(n, 2);
            var even = 0;
            var odd = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (s[s.Length - i - 1] == '1')
                {
                    if (i % 2 == 0) even++;
                    else odd++;
                }
            }

            return new[] {even, odd}; 
        }
    }
}
