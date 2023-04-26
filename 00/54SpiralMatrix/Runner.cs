using LeetCodeTasks.Utility;

namespace LeetCodeTasks._54SpiralMatrix
{
    public class Runner
    {
        public void Run()
        {
            //var strMatrix = "[[1,2,3],[4,5,6],[7,8,9]]";//[1,2,3,6,9,8,7,4,5]
            //var strMatrix = "[[1,2,3,4],[5,6,7,8],[9,10,11,12]]";//[1,2,3,4,8,12,11,10,9,5,6,7]
            var strMatrix = "[[7],[9],[6]]";//[7,9,6]
            var matrix = InputUtility.StringToIntArray2D(strMatrix);
            var cl = new SpiralMatrix();
            var result = cl.SpiralOrder(matrix);
            Console.WriteLine(ResultUtility.List(result));
        }
    }
}
