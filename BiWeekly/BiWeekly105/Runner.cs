using LeetCodeTasks.Utility;
using System.Collections.Generic;

namespace LeetCodeTasks.BiWeekly105
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new ExtraCharactersinaString();
            //var s = "leetscode"; var dictionary = new string[] { "leet", "code", "leetcode" };//1
            var s = "sayhelloworld"; var dictionary = new string[] { "hello", "world" };//3
            var result = cl.MinExtraChar(s, dictionary);
            Console.WriteLine(result);
            */

            var cl = new MaximumStrengthofaGroup();
            //var strNums = "[3,-1,-5,2,5,-9]";//1350
            //var strNums = "[-4,-5,-4]";//20
            var strNums = "[0,-1]";//0
            //var strNums = "[8,8,-6,-4,-6,-4,-6,-5,0,-9,-6,-3]";//59719680
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.MaxStrength(nums);
            Console.WriteLine(result);
        }
    }
}
