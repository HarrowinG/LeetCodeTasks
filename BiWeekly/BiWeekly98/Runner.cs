using LeetCodeTasks.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly98
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new MaximumDifferencebyRemappingaDigit();
            //var num = 11891;//99009
            var num = 90;//99
            var result = cl.MinMaxDifference(num);
            Console.WriteLine(result);
            */

            /*
            var cl = new MinimumScorebyChangingTwoElements();
            //var strNums = "[1,4,3]";//0
            var strNums = "[1,4,7,8,5]";//3
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.MinimizeSum(nums);
            Console.WriteLine(result);
            */

            var cl = new MinimumImpossibleOR();
            var strNums = "[2,1]";//4
            //var strNums = "[5,3,2]";//1
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.MinImpossibleOR(nums);
            Console.WriteLine(result);
        }
    }
}
