using LeetCodeTasks.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly100
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new DistributeMoneytoMaximumChildren();
            var money = 20; var children = 3;//1
            //var money = 16; var children = 2;//2
            var result = cl.DistMoney(money, children);
            Console.WriteLine(result);
            */

            /*
            var cl = new MaximizeGreatnessofanArray();
            //var strNums = "[1,3,5,2,1,3,1]";//4
            //var strNums = "[1,2,3,4]";//3
            var strNums = "[65,84,91,18,59,27,9,81,33,17]";//9
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.MaximizeGreatness(nums);
            Console.WriteLine(result);
            */

            var cl = new FindScoreofanArrayAfterMarkingAllElements();
            var strNums = "[2,1,3,4,5,2]";//7
            //var strNums = "[2,3,5,1,3,2]";//5
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.FindScore(nums);
            Console.WriteLine(result);
        }
    }
}
