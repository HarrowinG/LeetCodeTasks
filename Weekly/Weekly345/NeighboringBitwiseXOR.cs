using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly345
{
    public class NeighboringBitwiseXOR
    {
        public bool DoesValidArrayExist(int[] derived)
        {
            //xor(derived) = (A[0]^A[1])^(A[1]^A[2])^ .... ^(A[n-1]^A[0]) = 0
            var res = 0;
            foreach (var item in derived)
                res ^= item;

            return res == 0;
        }
    }
}
