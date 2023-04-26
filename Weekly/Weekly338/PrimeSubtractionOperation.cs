using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly338
{
    public class PrimeSubtractionOperation
    {//todo
        public bool PrimeSubOperation(int[] nums)
        {
            var listPrimes = new List<int>();
            for (var i = 1; i <= 1000; i++)
                if (IsPrime(i))
                    listPrimes.Add(i);

            for (var i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] < nums[i + 1]) continue;

                for (var j = 0; j < listPrimes.Count; j++)
                {
                    if (listPrimes[j] >= nums[i]) return false;
                    if (nums[i] - listPrimes[j] < nums[i + 1])
                    {
                        nums[i] -= listPrimes[j];
                        break;
                    }
                }
            }

            return true;
        }

        private static bool IsPrime(int number)
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
