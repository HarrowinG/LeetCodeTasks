using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1020NumberofEnclaves
{
    public class Runner
    {
        public void Run()
        {
            var cl = new NumberofEnclaves();
            var strGrid = "[[0,0,0,0],[1,0,1,0],[0,1,1,0],[0,0,0,0]]";//3
            //var strGrid = "[[0,1,1,0],[0,0,1,0],[0,0,1,0],[0,0,0,0]]";//0
            var grid = InputUtility.StringToIntArray2D(strGrid);
            var result = cl.NumEnclaves(grid);
            Console.WriteLine(result);
        }
    }
}
