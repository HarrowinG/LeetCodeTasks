using LeetCodeTasks.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly342
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new SumMultiples();
            //var n = 7;//21
            var n = 10;//40
            var result = cl.SumOfMultiples(n);
            Console.WriteLine(result);
            */

            /*
            var cl = new SlidingSubarrayBeauty();
            //var strNums = "[1,-1,-3,-2,3]"; var k = 3; var x = 2;//[-1,-2,-2]
            //var strNums = "[-1,-2,-3,-4,-5]"; var k = 2; var x = 2;//[-1,-2,-3,-4]
            var strNums = "[-3,1,2,-3,0,-3]"; var k = 2; var x = 1;//[-3,0,-3,-3,-3]
            //var strNums = "[-50,14]"; var k = 2; var x = 2;//[0]
            //var strNums = "[-46,-34,-46]"; var k = 3; var x = 3;//[-34]
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.GetSubarrayBeauty(nums, k, x);
            Console.WriteLine(ResultUtility.Array(result));
            */

            var cl = new MinimumNumberofOperationstoMakeAllArrayElementsEqualto1();
            var strNums = "[2,6,3,4]";//4
            //var strNums = "[2,10,6,14]";//-1
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.MinOperations(nums);
            Console.WriteLine(result);
        }
    }
}
