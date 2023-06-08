using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1351CountNegativeNumbersinaSortedMatrix
{
    public class Runner
    {
        public void Run()
        {
            var cl = new CountNegativeNumbersinaSortedMatrix();
            //var strGrid = "[[4,3,2,-1],[3,2,1,-1],[1,1,-1,-2],[-1,-1,-2,-3]]";//8
            //var strGrid = "[[3,2],[1,0]]";//0
            var strGrid = "[[5,1,0],[-5,-5,-5]]";//3
            var grid = InputUtility.StringToIntArray2D(strGrid);
            var result = cl.CountNegatives(grid);
            Console.WriteLine(result);
        }
    }
}
