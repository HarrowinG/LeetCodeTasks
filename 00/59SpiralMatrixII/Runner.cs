using LeetCodeTasks.Utility;

namespace LeetCodeTasks._59SpiralMatrixII
{
    public class Runner
    {
        public void Run()
        {
            var cl = new SpiralMatrixII();
            //var n = 3;//[[1,2,3],[8,9,4],[7,6,5]]
            var n = 1;//[[1]]
            var result = cl.GenerateMatrix(n);
            Console.WriteLine(ResultUtility.Array2D(result));
        }
    }
}
