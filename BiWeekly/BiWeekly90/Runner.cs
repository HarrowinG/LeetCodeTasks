using LeetCodeTasks.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly90
{
    public class Runner
    {
        public void Run()
        {
            /*
            //var words = new string[] {"adc", "wzy", "abc"};//"abc"
            var words = new string[] { "aaa", "bob", "ccc", "ddd" };//"bob"
            var cl = new _6225OddStringDifference();
            var result = cl.OddString(words);
            Console.WriteLine(result);
            */

            /*
            //var queries = new string[] { "word", "note", "ants", "wood" }; var dictionary = new string[] { "wood", "joke", "moat" };//["word","note","wood"]
            var queries = new string[] { "yes" }; var dictionary = new string[] { "not" };//[]
            var cl = new _6228WordsWithinTwoEditsofDictionary();
            var result = cl.TwoEditWords(queries, dictionary);
            Console.WriteLine(ResultUtility.List(result));
            */

            //var strNums = "[3,7,8,1,1,5]"; var space = 2;//1
            //var strNums = "[1,3,5,2,4,6]"; var space = 2;//1
            //var strNums = "[6,2,5]"; var space = 100;//2
            //var strNums = "[494220881]"; var space = 4;//494220881
            var strNums = "[547552986,597477111]"; var space = 4;//547552986
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new _6226DestroySequentialTargets();
            var result = cl.DestroyTargets(nums, space);
            Console.WriteLine(result);
        }
    }
}
