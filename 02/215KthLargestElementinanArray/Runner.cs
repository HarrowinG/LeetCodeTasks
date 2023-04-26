using LeetCodeTasks.Utility;

namespace LeetCodeTasks._215KthLargestElementinanArray
{
    public class Runner
    {
        public void Run()
        {
            //var strNums = "[3,2,1,5,6,4]"; var k = 2;//5
            var strNums = "[3,2,3,1,2,4,5,5,6]"; var k = 4;//4
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new KthLargestElementinanArray();
            var result = cl.FindKthLargest(nums, k);
            Console.WriteLine(result);
        }
    }
}
