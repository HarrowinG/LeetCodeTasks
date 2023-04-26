using LeetCodeTasks.Utility;

namespace LeetCodeTasks._128LongestConsecutiveSequence
{
    public class Runner
    {
        public void Run()
        {
            //var strNums = "[100,4,200,1,3,2]";//4
            var strNums = "[0,3,7,2,5,8,4,6,0,1]";//9
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new LongestConsecutiveSequence();
            var result = cl.LongestConsecutive(nums);
            Console.WriteLine(result);
        }
    }
}
