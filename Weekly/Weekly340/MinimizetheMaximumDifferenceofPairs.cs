using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly340
{
    public class MinimizetheMaximumDifferenceofPairs
    {
        public int MinimizeMax(int[] nums, int p)
        {
            Array.Sort(nums);
            var deltas = new List<int>();
            for (var i = 1; i < nums.Length; i++)
                deltas.Add(nums[i] - nums[i - 1]);

            return 0;
        }
    }
}
