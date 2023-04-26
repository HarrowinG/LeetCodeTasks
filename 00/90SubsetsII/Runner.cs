using LeetCodeTasks.Utility;

namespace LeetCodeTasks._90SubsetsII
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[1,2,2]";//[[],[1],[1,2],[1,2,2],[2],[2,2]]
            //var strNums = "[0]";//[[],[0]]
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new SubsetsII();
            var result = cl.SubsetsWithDup(nums);
            Console.WriteLine(ResultUtility.List2D(result));
        }
    }
}
