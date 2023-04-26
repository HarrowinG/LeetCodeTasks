using LeetCodeTasks.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly333
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new MergeTwo2DArraysbySummingValues();
            //var strNums1 = "[[1,2],[2,3],[4,5]]"; var strNums2 = "[[1,4],[3,2],[4,1]]";//[[1,6],[2,3],[3,2],[4,6]]
            var strNums1 = "[[2,4],[3,6],[5,5]]"; var strNums2 = "[[1,3],[4,3]]";//[[1,3],[2,4],[3,6],[4,3],[5,5]]
            var nums1 = InputUtility.StringToIntArray2D(strNums1);
            var nums2 = InputUtility.StringToIntArray2D(strNums2);
            var result = cl.MergeArrays(nums1, nums2);
            Console.WriteLine(ResultUtility.Array2D(result));
            */

            /*
            var cl = new MinimumOperationstoReduceanIntegerto0();
            var n = 39;//3
            //var n = 54;//3
            var result = cl.MinOperations(n);
            Console.WriteLine(result);
            */

            var cl = new CounttheNumberofSquareFreeSubsets();
            var strNums = "[3,4,4,5]";//3
            //var strNums = "[1]";//1
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.SquareFreeSubsets(nums);
            Console.WriteLine(result);
        }
    }
}
