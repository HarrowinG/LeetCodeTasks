using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1799MaximizeScoreAfterNOperations
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MaximizeScoreAfterNOperations();
            //var strNums = "[1,2]";//1
            //var strNums = "[3,4,6,8]";//11
            var strNums = "[1,2,3,4,5,6]";//14
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.MaxScore(nums);
            Console.WriteLine(result);
        }
    }
}
