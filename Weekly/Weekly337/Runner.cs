using LeetCodeTasks.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly337
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new NumberofEvenandOddBits();
            //var n = 17;//[2,0]
            var n = 2;//[0,1]
            var result = cl.EvenOddBit(n);
            Console.WriteLine(ResultUtility.Array(result));
            */

            /*
            var cl = new CheckKnightTourConfiguration();
            //var strGrid = "[[0,11,16,5,20],[17,4,19,10,15],[12,1,8,21,6],[3,18,23,14,9],[24,13,2,7,22]]";//true
            var strGrid = "[[0,3,6],[5,8,1],[2,7,4]]";//false
            var grid = InputUtility.StringToIntArray2D(strGrid);
            var result = cl.CheckValidGrid(grid);
            Console.WriteLine(result);
            */

            var cl = new TheNumberofBeautifulSubsets();
            //var strNums = "[2,4,6]"; var k = 2;//4
            //var strNums = "[1]"; var k = 1;//1
            var strNums = "[4,2,5,9,10,3]"; var k = 1;//23
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.BeautifulSubsets(nums, k);
            Console.WriteLine(result);
        }
    }
}
