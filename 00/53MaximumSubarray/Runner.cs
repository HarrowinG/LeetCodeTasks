using LeetCodeTasks.Utility;

namespace LeetCodeTasks._53MaximumSubarray
{
    public class Runner
    {
        public void Run()
        {
            //var strNums = "[-2,1,-3,4,-1,2,1,-5,4]"; //6
            //var strNums = "[1]"; //1
            var strNums = "[5,4,-1,7,8]"; //23
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new MaximumSubarray();
            var result = cl.MaxSubArray(nums);
            Console.WriteLine(result);
        }
    }
}
