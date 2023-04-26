using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2435PathsinMatrixWhoseSumIsDivisiblebyK
{
    public class Runner
    {
        public void Run()
        {
            //var k = 3; var strGrid = "[[5,2,4],[3,0,5],[0,7,2]]";//2
            //var k = 5; var strGrid = "[[0,0]]";//1
            var k = 1; var strGrid = "[[7,3,4,9],[2,3,6,2],[2,3,7,0]]";//10
            var grid = InputUtility.StringToIntArray2D(strGrid);
            var cl = new PathsinMatrixWhoseSumIsDivisiblebyK();
            var result = cl.NumberOfPaths(grid, k);
            Console.WriteLine(result);
        }
    }
}
