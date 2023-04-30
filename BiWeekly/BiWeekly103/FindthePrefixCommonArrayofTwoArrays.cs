using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly103
{
    public class FindthePrefixCommonArrayofTwoArrays
    {
        public int[] FindThePrefixCommonArray(int[] A, int[] B)
        {
            var setA = new HashSet<int>();
            var setB = new HashSet<int>();
            var result = new int[A.Length];

            for (var i = 0; i < A.Length; i++)
            {
                setA.Add(A[i]);
                setB.Add(B[i]);
                var res = setA.Intersect(setB).Count();
                result[i] = res;
            }

            return result;
        }
    }
}
