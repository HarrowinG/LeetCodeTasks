using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly90
{
    public class _6226DestroySequentialTargets
    {
        public int DestroyTargets(int[] nums, int space)
        {
            Array.Sort(nums);
            var dict = new Dictionary<long, int>();
            var maxNumber = nums[nums.Length - 1];
            foreach (var num in nums)
                dict[num] = dict.GetValueOrDefault(num, 0) + 1;

            var dp = new Dictionary<(long, long), int>();
            var maxCount = 0;
            var result = nums[0];
            for (var i = 0; i < nums.Length; i++)
            {
                for (var c = 1; c <= maxNumber; c++)
                {
                    long target = nums[i] + c * space;
                    if (target > maxNumber) break;

                    var count = Dfs(dict, target, c, space, maxNumber, dp);
                    if (count > maxCount)
                    {
                        maxCount = count;
                        result = nums[i];
                    }
                }

                while (i + 1 < nums.Length && nums[i] == nums[i + 1]) i++;
            }

            return result;
        }

        private int Dfs(Dictionary<long, int> dict, long num, int c, int space, int maxNumber, Dictionary<(long, long), int> dp)
        {
            if (num > maxNumber) return 0;

            var key = (num, c);
            if (!dp.ContainsKey(key))
            {
                dp[key] = 0;
                if (dict.ContainsKey(num))
                    dp[key] += dict[num];

                dp[key] += Dfs(dict, num + c * space, c, space, maxNumber, dp);
            }
            return dp[key];
        }
    }
}
