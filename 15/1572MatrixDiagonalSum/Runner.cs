using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1572MatrixDiagonalSum
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MatrixDiagonalSum();
            //var strMat = "[[1,2,3],[4,5,6],[7,8,9]]";//25
            //var strMat = "[[1,1,1,1],[1,1,1,1],[1,1,1,1],[1,1,1,1]]";//8
            var strMat = "[[5]]";//5
            var mat = InputUtility.StringToIntArray2D(strMat);
            var result = cl.DiagonalSum(mat);
            Console.WriteLine(result);
        }
    }
}
