using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2352EqualRowandColumnPairs
{
    public class Runner
    {
        public void Run()
        {
            var cl = new EqualRowandColumnPairs();
            var strGrid = "[[3,2,1],[1,7,6],[2,7,7]]";//1
            //var strGrid = "[[3,1,2,2],[1,4,4,5],[2,4,2,2],[2,4,2,2]]";//3
            //var strGrid = "[[3,1,2,2],[1,4,4,4],[2,4,2,2],[2,5,2,2]]";//3
            var grid = InputUtility.StringToIntArray2D(strGrid);
            var result = cl.EqualPairs(grid);
            Console.WriteLine(result);
        }
    }
}
