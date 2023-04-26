using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2411SmallestSubarraysWithMaximumBitwiseOR
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[1,0,2,1,3]";//[3,3,2,2,1]
            //var strNums = "[1,2]";//[2,1]
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new SmallestSubarraysWithMaximumBitwiseOR();
            var result = cl.SmallestSubarrays(nums);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
