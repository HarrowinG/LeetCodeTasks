using LeetCodeTasks.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly334
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new LeftandRightSumDifferences();
            //var strNums = "[10,4,8,3]";//[15,1,11,22]
            var strNums = "[1]";//[0]
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.LeftRigthDifference(nums);
            Console.WriteLine(ResultUtility.Array(result));
            */

            /*
            var cl = new FindtheDivisibilityArrayofaString();
            var word = "998244353"; var m = 3;//[1,1,0,0,0,1,1,0,0]
            //var word = "1010"; var m = 10;//[0,1,0,1]
            var result = cl.DivisibilityArray(word, m);
            Console.WriteLine(ResultUtility.Array(result));
            */

            var cl = new FindtheMaximumNumberofMarkedIndices();
            //var strNums = "[3,5,2,4]";//2
            //var strNums = "[9,2,5,4]";//4
            var strNums = "[7,6,8]";//0
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.MaxNumOfMarkedIndices(nums);
            Console.WriteLine(result);
        }
    }
}
