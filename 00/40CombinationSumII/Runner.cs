using LeetCodeTasks.Utility;

namespace LeetCodeTasks._40CombinationSumII
{
    public class Runner
    {
        public void Run()
        {
            var nums = "[10,1,2,7,6,1,5]"; var target = 8;//[[1,1,6],[1,2,5],[1,7],[2,6]]
            //var nums = "[2,5,2,1,2]"; var target = 5;//[[1,2,2],[5]]
            var candidates = InputUtility.StringToIntArray(nums);
            var cl = new CombinationSumII();
            var result = cl.CombinationSum2(candidates, target);
            Console.WriteLine(ResultUtility.List2D(result));
        }
    }
}
