using LeetCodeTasks.Utility;

namespace LeetCodeTasks._416PartitionEqualSubsetSum
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[1,5,11,5]";//true
            //var strNums = "[1,2,3,5]";//false
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new PartitionEqualSubsetSum();
            var result = cl.CanPartition(nums);
            Console.WriteLine(result);
        }
    }
}
