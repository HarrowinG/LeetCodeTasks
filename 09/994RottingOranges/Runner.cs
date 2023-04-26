using LeetCodeTasks.Utility;

namespace LeetCodeTasks._994RottingOranges
{
    public class Runner
    {
        public void Run()
        {
            var nums = "[[2,1,1],[1,1,0],[0,1,1]]";//4
            //var nums = "[[2,1,1],[0,1,1],[1,0,1]]";//-1
            //var nums = "[[0,2]]";//0
            //var nums = "[[2,1,1],[1,1,1],[0,1,2]]";//2
            //var nums = "[[0]]";//0
            var grid = InputUtility.StringToIntArray2D(nums);
            var cl = new RottingOranges();
            var result = cl.OrangesRotting(grid);
            Console.WriteLine(result);
        }
    }
}
