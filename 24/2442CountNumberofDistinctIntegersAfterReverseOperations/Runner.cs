using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2442CountNumberofDistinctIntegersAfterReverseOperations
{
    public class Runner
    {
        public void Run()
        {
            //var strNums = "[1,13,10,12,31]";//6
            var strNums = "[2,2,2]";//1
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new CountNumberofDistinctIntegersAfterReverseOperations();
            var result = cl.CountDistinctIntegers(nums);
            Console.WriteLine(result);
        }
    }
}
