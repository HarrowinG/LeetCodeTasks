using LeetCodeTasks.Utility;

namespace LeetCodeTasks._152MaximumProductSubarray
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[2,3,-2,4]";//6
            //var strNums = "[-2,0,-1]";//0
            //var strNums = "[-2]";//-2
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new MaximumProductSubarray();
            var result = cl.MaxProduct(nums);
            Console.WriteLine(result);
        }
    }
}
