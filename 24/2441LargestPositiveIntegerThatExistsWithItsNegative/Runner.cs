using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2441LargestPositiveIntegerThatExistsWithItsNegative
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[-1,2,-3,3]";//3
            //var strNums = "[-1,10,6,7,-7,1]";//7
            //var strNums = "[-10,8,6,7,-2,-3]";//-1
            //var strNums = "[14,33,40,-33,8,-24,-42,30,-18,-34]";//33
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new LargestPositiveIntegerThatExistsWithItsNegative();
            var result = cl.FindMaxK(nums);
            Console.WriteLine(result);
        }
    }
}
