using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly333
{
    public class MergeTwo2DArraysbySummingValues
    {
        public int[][] MergeArrays(int[][] nums1, int[][] nums2)
        {
            var result = new List<int[]>();
            var id1 = 0;
            var id2 = 0;
            while (id1 < nums1.Length && id2 < nums2.Length)
            {
                if (nums1[id1][0] == nums2[id2][0])
                {
                    result.Add(new[] { nums1[id1][0], nums1[id1][1] + nums2[id2][1] });
                    id1++;
                    id2++;
                }
                else if (nums1[id1][0] < nums2[id2][0])
                {
                    result.Add(new[] { nums1[id1][0], nums1[id1][1]});
                    id1++;
                }
                else
                {
                    result.Add(new[] { nums2[id2][0], nums2[id2][1] });
                    id2++;
                }
            }
            while (id1 < nums1.Length)
            {
                result.Add(new[] { nums1[id1][0], nums1[id1][1] });
                id1++;
            }
            while (id2 < nums2.Length)
            {
                result.Add(new[] { nums2[id2][0], nums2[id2][1] });
                id2++;
            }

            return result.ToArray();
        }
    }
}
