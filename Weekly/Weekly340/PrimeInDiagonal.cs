using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly340
{
    public class PrimeInDiagonal
    {
        public int DiagonalPrime(int[][] nums)
        {
            var result = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (IsPrime(nums[i][i]))
                    result = Math.Max(result, nums[i][i]);
                if (IsPrime(nums[i][nums.Length - 1 - i]))
                    result = Math.Max(result, nums[i][nums.Length - 1 - i]);
            }

            return result;
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
