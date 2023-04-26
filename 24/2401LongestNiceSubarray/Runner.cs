using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2401LongestNiceSubarray
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[1,3,8,48,10]";//3
            //var strNums = "[3,1,5,11,13]";//1
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new LongestNiceSubarrayClass();
            var result = cl.LongestNiceSubarray(nums);
            Console.WriteLine(result);
        }
    }
}
