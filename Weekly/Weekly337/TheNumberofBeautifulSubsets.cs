using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly337
{
    public class TheNumberofBeautifulSubsets
    {
        public int BeautifulSubsets(int[] nums, int k)
        {
            var result = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                var set = new HashSet<int> { nums[i] };
                Dfs(nums, i + 1, k, set, ref result);
            }

            return result;
        }

        private void Dfs(int[] nums, int id, int k, HashSet<int> set, ref int result)
        {
            if (id == nums.Length)
            {
                result++;
                return;
            }

            if (set.Contains(nums[id] - k) || set.Contains(nums[id] + k))
            {
                Dfs(nums, id + 1, k, set, ref result);
            }
            else
            {
                set.Add(nums[id]);
                Dfs(nums, id + 1, k, set, ref result);
                set.Remove(nums[id]);
                Dfs(nums, id + 1, k, set, ref result);
            }
        }
    }
}
