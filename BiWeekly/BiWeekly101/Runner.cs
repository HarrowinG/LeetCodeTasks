using LeetCodeTasks.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly101
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new FormSmallestNumberFromTwoDigitArrays();
            //var strNums1 = "[4,1,3]"; var strNums2 = "[5,7]";//15
            var strNums1 = "[4,3]"; var strNums2 = "[5,1,7]";//13
            //var strNums1 = "[3,5,2,6]"; var strNums2 = "[3,1,7]";//3
            var nums1 = InputUtility.StringToIntArray(strNums1);
            var nums2 = InputUtility.StringToIntArray(strNums2);
            var result = cl.MinNumber(nums1, nums2);
            Console.WriteLine(result);
            */

            /*
            var cl = new FindtheSubstringWithMaximumCost();
            //var s = "adaa"; var chars = "d"; var strVals = "[-1000]";//2
            //var s = "abc"; var chars = "abc"; var strVals = "[-1,-1,-1]";//0
            var s = "abc"; var chars = "abc"; var strVals = "[100,-1,200]";//299
            var vals = InputUtility.StringToIntArray(strVals);
            var result = cl.MaximumCostSubstring(s, chars, vals);
            Console.WriteLine(result);
            */

            /*
            var cl = new MakeKSubarraySumsEqual();
            var strArr = "[1,4,1,3]"; var k = 2;//1
            //var strArr = "[2,5,5,7]"; var k = 3;//5
            var arr = InputUtility.StringToIntArray(strArr);
            var result = cl.MakeSubKSumEqual(arr, k);
            Console.WriteLine(result);
            */

            var cl = new ShortestCycleinaGraph();
            var n = 6; var strEdges = "[[0,1],[0,5],[1,2],[1,5],[2,3],[3,4],[4,5]]";//3
            //var n = 7; var strEdges = "[[0,1],[1,2],[2,0],[3,4],[4,5],[5,6],[6,3]]";//3
            //var n = 4; var strEdges = "[[0,1],[0,2]]";//-1
            var edges = InputUtility.StringToIntArray2D(strEdges);
            var result = cl.FindShortestCycle(n, edges);
            Console.WriteLine(result);
        }
    }
}
