using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2395FindSubarraysWithEqualSum
{
    public class Runner
    {
        public void Run()
        {
            //var strNums = "[4,2,4]";//true
            //var strNums = "[1,2,3,4,5]";//false
            var strNums = "[0,0,0]";//true
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new FindSubarraysWithEqualSum();
            var result = cl.FindSubarrays(nums);
            Console.WriteLine(result);
        }
    }
}
