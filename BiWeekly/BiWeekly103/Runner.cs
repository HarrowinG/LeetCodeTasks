using LeetCodeTasks.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly103
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new MaximumSumWithExactlyKElements();
            //var strNums = "[1,2,3,4,5]"; var k = 3;//18
            var strNums = "[5,5,5]"; var k = 2;//11
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.MaximizeSum(nums, k);
            Console.WriteLine(result);
            */

            /*
            var cl = new FindthePrefixCommonArrayofTwoArrays();
            //var strA = "[1,3,2,4]"; var strB = "[3,1,2,4]";//[0,2,3,4]
            var strA = "[2,3,1]"; var strB = "[3,1,2]";//[0,1,3]
            var a = InputUtility.StringToIntArray(strA);
            var b = InputUtility.StringToIntArray(strB);
            var result = cl.FindThePrefixCommonArray(a, b);
            Console.WriteLine(ResultUtility.Array(result));
            */

            /*
            var cl = new MaximumNumberofFishinaGrid();
            //var strGrid = "[[0,2,1,0],[4,0,0,3],[1,0,0,4],[0,3,2,0]]";//7
            var strGrid = "[[1,0,0,0],[0,0,0,0],[0,0,0,0],[0,0,0,1]]";//1
            var grid = InputUtility.StringToIntArray2D(strGrid);
            var result = cl.FindMaxFish(grid);
            Console.WriteLine(result);
            */

            var cl = new MakeArrayEmpty();
            //var strNums = "[3,4,-1]";//5
            //var strNums = "[1,2,4,3]";//5
            //var strNums = "[1,2,3]";//3
            var strNums = "[-15,-19,5]";//5
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.CountOperationsToEmptyArray(nums);
            Console.WriteLine(result);
        }
    }
}
