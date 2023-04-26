using System.Numerics;

namespace LeetCodeTasks._2427NumberofCommonFactors
{
    public class NumberofCommonFactors
    {
        public int CommonFactors(int a, int b)
        {
            var result = 1;
            var gcd = BigInteger.GreatestCommonDivisor(a, b);
            for (var i = 2; i <= gcd; i++)
                if (a % i == 0 && b % i == 0) result++;

            return result;
        }
    }
}
