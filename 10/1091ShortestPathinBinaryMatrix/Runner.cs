using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1091ShortestPathinBinaryMatrix
{
    public class Runner
    {
        public void Run()
        {
            var cl = new ShortestPathinBinaryMatrix();
            //var strGrid = "[[0,1],[1,0]]";//2
            //var strGrid = "[[0,0,0],[1,1,0],[1,1,0]]";//4
            var strGrid = "[[1,0,0],[1,1,0],[1,1,0]]";//-1
            var grid = InputUtility.StringToIntArray2D(strGrid);
            var result = cl.ShortestPathBinaryMatrix(grid);
            Console.WriteLine(result);
        }
    }
}
