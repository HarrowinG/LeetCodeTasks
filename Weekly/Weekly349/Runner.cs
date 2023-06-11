using LeetCodeTasks.Utility;

namespace LeetCodeTasks.Weekly349
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new LexicographicallySmallestStringAfterSubstringOperation();
            //var s = "cbabc";//baabc
            //var s = "acbbc";//abaab
            //var s = "leetcode";//kddsbncd
            var s = "aaa";//aaz
            var result = cl.SmallestString(s);
            Console.WriteLine(result);
            */

            var cl = new CollectingChocolates();
            var strNums = "[20,1,15]"; var x = 5;//13
            //var strNums = "[1,2,3]"; var x = 4;//6
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.MinCost(nums, x);
            Console.WriteLine(result);
        }
    }
}
