using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly101
{
    public class FormSmallestNumberFromTwoDigitArrays
    {
        public int MinNumber(int[] nums1, int[] nums2)
        {
            var set = new HashSet<int>();
            var min1 = int.MaxValue; var min2 = int.MaxValue;
            var intersect = int.MaxValue;
            for (var i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] < min1) min1 = nums1[i];

                set.Add(nums1[i]);
            }

            for (var i = 0; i < nums2.Length; i++)
            {
                if (nums2[i] < min2) min2 = nums2[i];

                if (set.Contains(nums2[i]) && nums2[i] < intersect) intersect = nums2[i];
            }

            return intersect == int.MaxValue
                ? min1 < min2 ? min1 * 10 + min2 : min2 * 10 + min1
                : intersect;
        }
    }
}
