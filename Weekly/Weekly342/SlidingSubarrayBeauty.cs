using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly342
{
    public class SlidingSubarrayBeauty
    {
        public int[] GetSubarrayBeauty(int[] nums, int k, int x)
        {
            var res = new int[nums.Length - k + 1];
            var sl = new List<int>();
            var i = 0;
            for (; i < k; i++)
                sl.Add(nums[i]);
            sl.Sort();

            for (; i <= nums.Length; i++)
            {
                if (sl[x - 1] < 0)
                    res[i - k] = sl[x - 1];

                if (i == nums.Length) break;

                sl.RemoveAt(Bs(sl, nums[i - k]));
                sl.Insert(Bs(sl, nums[i]), nums[i]);
            }

            return res;
        }

        private int Bs(List<int> sl, int val)
        {
            var l = 0; var r = sl.Count - 1;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                if (sl[mid] == val) return mid;
                else if (sl[mid] < val) l = mid + 1;
                else r = mid - 1;
            }

            return l;
        }
    }
}
