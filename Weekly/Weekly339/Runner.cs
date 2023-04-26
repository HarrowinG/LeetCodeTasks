using LeetCodeTasks.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly339
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new FindtheLongestBalancedSubstringofaBinaryString();
            //var s = "01000111";//6
            //var s = "00111";//4
            //var s = "111";//0
            var s = "110";//0
            var result = cl.FindTheLongestBalancedSubstring(s);
            Console.WriteLine(result);
            */

            /*
            var cl = new ConvertanArrayIntoa2DArrayWithConditions();
            //var strNums = "[1,3,4,1,2,3,1]";//[[1,3,4,2],[1,3],[1]]
            var strNums = "[1,2,3,4]";//[[4,3,2,1]]
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.FindMatrix(nums);
            Console.WriteLine(ResultUtility.List2D(result));
            */

            var cl = new MiceandCheese();
            var strReward1 = "[1,1,3,4]"; var strReward2 = "[4,4,1,1]"; var k = 2;//15
            //var strReward1 = "[1,1]"; var strReward2 = "[1,1]"; var k = 2;//2
            var reward1 = InputUtility.StringToIntArray(strReward1);
            var reward2 = InputUtility.StringToIntArray(strReward2);
            var result = cl.MiceAndCheese(reward1, reward2, k);
            Console.WriteLine(result);
        }
    }
}
