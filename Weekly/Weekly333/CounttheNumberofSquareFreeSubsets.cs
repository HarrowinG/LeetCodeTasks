using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly333
{
    public class CounttheNumberofSquareFreeSubsets
    {
        public int SquareFreeSubsets(int[] nums)
        {
            var modulo = 1000000007;
            var squares = new List<int> { 4, 9, 16, 25};
            var free = new List<int>();
            var countFreeSquare = 0;
            foreach (var n in nums)
            {
                if (IsFree(n, squares))
                {
                    countFreeSquare++;
                    free.Add(n);
                }
            }
            //todo

            return countFreeSquare;
        }

        private bool IsFree(int n, List<int> squares)
        {
            foreach (var s in squares)
            {
                if (n / s * s == n)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
