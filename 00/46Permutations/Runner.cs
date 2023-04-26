using LeetCodeTasks.Utility;

namespace LeetCodeTasks._46Permutations
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[1,2,3]";//[[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
            //var strNums = "[0,1]";//[[0,1],[1,0]]
            //var strNums = "[1]";//[[1]]
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new Permutations();
            var result = cl.Permute(nums);
            Console.WriteLine(ResultUtility.List2D(result));
        }
    }
}
