using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly338
{
    public class KItemsWiththeMaximumSum
    {
        public int KItemsWithMaximumSum(int numOnes, int numZeros, int numNegOnes, int k)
        {
            if (k <= numOnes) return k;

            k -= numOnes;
            if (k <= numZeros) return numOnes;

            k -= numZeros;
            return numOnes - k;
        }
    }
}
