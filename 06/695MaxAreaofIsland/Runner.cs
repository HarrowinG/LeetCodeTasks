using LeetCodeTasks.Utility;

namespace LeetCodeTasks._695MaxAreaofIsland
{
    public class Runner
    {
        public void Run()
        {
            //var nums = "[[0,0,1,0,0,0,0,1,0,0,0,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,1,1,0,1,0,0,0,0,0,0,0,0],[0,1,0,0,1,1,0,0,1,0,1,0,0],[0,1,0,0,1,1,0,0,1,1,1,0,0],[0,0,0,0,0,0,0,0,0,0,1,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,0,0,0,0,0,0,1,1,0,0,0,0]]";//6
            var nums = "[[0,0,0,0,0,0,0,0]]";//0
            var grid = InputUtility.StringToIntArray2D(nums);
            var cl = new MaxAreaofIslandClass();
            var result = cl.MaxAreaOfIsland(grid);
            Console.WriteLine(result);
        }
    }
}
