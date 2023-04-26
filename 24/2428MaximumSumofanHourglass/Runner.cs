using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2428MaximumSumofanHourglass
{
    public class Runner
    {
        public void Run()
        {
            //var strGrid = "[[6,2,1,3],[4,2,1,5],[9,2,8,7],[4,1,2,9]]";//30
            var strGrid = "[[1,2,3],[4,5,6],[7,8,9]]";//35
            var grid = InputUtility.StringToIntArray2D(strGrid);
            var cl = new MaximumSumofanHourglass();
            var result = cl.MaxSum(grid);
            Console.WriteLine(result);
        }
    }
}
