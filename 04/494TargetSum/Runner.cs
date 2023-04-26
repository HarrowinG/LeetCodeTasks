using LeetCodeTasks.Utility;

namespace LeetCodeTasks._494TargetSum
{
    public class Runner
    {
        public void Run()
        {
            //var strNums = "[1,1,1,1,1]"; var target = 3;//5
            //var strNums = "[1]"; var target = 1;//1
            var strNums = "[2,2,2,1,1,1,1]"; var target = 6;//9
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new TargetSum();
            var result = cl.FindTargetSumWays(nums, target);
            Console.WriteLine(result);
        }
    }
}
