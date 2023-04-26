using LeetCodeTasks.Utility;

namespace LeetCodeTasks._39CombinationSum
{
    public class Runner
    {
        public void Run()
        {
            //var nums = "[2,3,6,7]"; var target = 7;//[[2,2,3],[7]]
            //var nums = "[2,3,5]"; var target = 8;//[[2,2,2,2],[2,3,3],[3,5]]
            var nums = "[2]"; var target = 1;//[]
            var candidates = InputUtility.StringToIntArray(nums);
            var cl = new CombinationSumClass();
            var result = cl.CombinationSum(candidates, target);
            Console.WriteLine(ResultUtility.List2D(result));
        }
    }
}
