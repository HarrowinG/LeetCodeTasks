using System.Collections.Generic;

namespace LeetCodeTasks._2357MakeArrayZerobySubtractingEqualAmounts
{
    public class MakeArrayZerobySubtractingEqualAmounts
    {
        public int MinimumOperations(int[] nums)
        {
            var set = new HashSet<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                set.Add(nums[i]);
            }
            set.Remove(0);
            return set.Count;
        }
    }
}
