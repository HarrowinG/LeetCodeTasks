using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly104
{
    public class SuminaMatrix
    {
        public int MatrixSum(int[][] nums)
        {
            var result = 0;
            for (var i = 0; i < nums.Length; i++)
                Array.Sort(nums[i]);

            for (var j = nums[0].Length - 1; j >= 0; j--)
            {
                var max = int.MinValue;
                for (var i = 0; i < nums.Length; i++)
                {
                    max = Math.Max(max, nums[i][j]);
                }

                result += max;
            }

            return result;
        }
    }
}
