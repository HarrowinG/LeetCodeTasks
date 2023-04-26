using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly340
{
    public class SumofDistances
    {
        //tle
        public long[] Distance(int[] nums)
        {
            var result = new long[nums.Length];
            var dict = new Dictionary<int, List<int>>();
            for (var i = 0; i < nums.Length; i++)
            {
                dict[nums[i]] = dict.GetValueOrDefault(nums[i], new List<int>());
                dict[nums[i]].Add(i);
            }

            for (var i = 0; i < nums.Length; i++)
            {
                var indexes = dict[nums[i]];
                for (var j = 0; j < indexes.Count; j++)
                {
                    result[i] += Math.Abs(i - indexes[j]);
                }
            }

            return result;
        }
    }
}
