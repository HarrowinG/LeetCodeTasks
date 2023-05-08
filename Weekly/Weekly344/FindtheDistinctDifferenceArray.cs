using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly344
{
    public class FindtheDistinctDifferenceArray
    {
        public int[] DistinctDifferenceArray(int[] nums)
        {
            var result = new int[nums.Length];
            for (var i = nums.Length - 1; i >= 0; i--)
            {
                var prefix = nums[0..(i+1)].ToHashSet();
                var postfix = nums[(i+1)..nums.Length].ToHashSet();
                result[i] = prefix.Count - postfix.Count;
            }

            return result;
        }
    }
}
