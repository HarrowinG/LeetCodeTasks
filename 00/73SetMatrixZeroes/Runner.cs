using LeetCodeTasks.Utility;

namespace LeetCodeTasks._73SetMatrixZeroes
{
    public class Runner
    {
        public void Run()
        {
            //var strMatrix = "[[1,1,1],[1,0,1],[1,1,1]]";//[[1,0,1],[0,0,0],[1,0,1]]
            var strMatrix = "[[0,1,2,0],[3,4,5,2],[1,3,1,5]]";//[[0,0,0,0],[0,4,5,0],[0,3,1,0]]
            var matrix = InputUtility.StringToIntArray2D(strMatrix);
            var cl = new SetMatrixZeroes();
            cl.SetZeroes(matrix);
            Console.WriteLine(ResultUtility.Array2D(matrix));
        }
    }
}
