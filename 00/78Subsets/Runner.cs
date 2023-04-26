using LeetCodeTasks.Utility;

namespace LeetCodeTasks._78Subsets
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[1,2,3]";//[[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
            //var strNums = "[0]";//[[],[0]]
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new SubsetsClass();
            var result = cl.Subsets(nums);
            Console.WriteLine(ResultUtility.List2D(result));
        }
    }
}
