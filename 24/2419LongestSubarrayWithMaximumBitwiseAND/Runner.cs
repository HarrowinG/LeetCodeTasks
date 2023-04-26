using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2419LongestSubarrayWithMaximumBitwiseAND
{
    public class Runner
    {
        public void Run()
        {
            //var strNums = "[1,2,3,3,2,2]";//2
            //var strNums = "[1,2,3,4]";//1
            var strNums = "[378034,378034,378034]";//3
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new LongestSubarrayWithMaximumBitwiseAND();
            var result = cl.LongestSubarray(nums);
            Console.WriteLine(result);
        }
    }
}
