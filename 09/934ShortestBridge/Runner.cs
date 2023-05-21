using LeetCodeTasks.Utility;

namespace LeetCodeTasks._934ShortestBridge
{
    public class Runner
    {
        public void Run()
        {
            var cl = new ShortestBridgeClass();
            //var strGrid = "[[0,1],[1,0]]";//1
            var strGrid = "[[0,1,0],[0,0,0],[0,0,1]]";//2
            //var strGrid = "[[1,1,1,1,1],[1,0,0,0,1],[1,0,1,0,1],[1,0,0,0,1],[1,1,1,1,1]]";//1
            var grid = InputUtility.StringToIntArray2D(strGrid);
            var result = cl.ShortestBridge(grid);
            Console.WriteLine(result);
        }
    }
}
