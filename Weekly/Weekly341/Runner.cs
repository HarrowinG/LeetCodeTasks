using LeetCodeTasks.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly341
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new FindtheMaximumDivisibilityScore();
            //var strNums = "[4,7,9,3,9]"; var strDivisors = "[5,2,3]";//3
            //var strNums = "[20,14,21,10]"; var strDivisors = "[5,7,5]";//5
            var strNums = "[12]"; var strDivisors = "[10,16]";//10
            var nums = InputUtility.StringToIntArray(strNums);
            var divisors = InputUtility.StringToIntArray(strDivisors);
            var result = cl.MaxDivScore(nums, divisors);
            Console.WriteLine(result);
            */

            /*
            var cl = new MinimumAdditionstoMakeValidString();
            //var word = "b";//2
            //var word = "aaa";//6
            var word = "abc";//0
            var result = cl.AddMinimum(word);
            Console.WriteLine(result);
            */

            var cl = new MinimizetheTotalPriceoftheTrips();
            var n = 4; var strEdges = "[[0,1],[1,2],[1,3]]"; var strPrice = "[2,2,10,6]"; var strTrips = "[[0,3],[2,1],[2,3]]";//23
            //var n = 2; var strEdges = "[[0,1]]"; var strPrice = "[2,2]"; var strTrips = "[[0,0]]";//1
            var edges = InputUtility.StringToIntArray2D(strEdges);
            var price = InputUtility.StringToIntArray(strPrice);
            var trips = InputUtility.StringToIntArray2D(strTrips);
            var result = cl.MinimumTotalPrice(n, edges, price, trips);
            Console.WriteLine(result);
        }
    }
}
