using LeetCodeTasks.Utility;

namespace LeetCodeTasks.Weekly348
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new SemiOrderedPermutationClass();
            //var strNums = "[2,1,4,3]";//2
            //var strNums = "[2,4,1,3]";//3
            var strNums = "[1,3,4,2,5]";//0
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.SemiOrderedPermutation(nums);
            Console.WriteLine(result);
            */

            var cl = new SumofMatrixAfterQueries();
            var n = 3; var strQueries = "[[0,0,1],[1,2,2],[0,2,3],[1,0,4]]";//23
            //var n = 3; var strQueries = "[[0,0,4],[0,1,2],[1,0,1],[0,2,3],[1,2,1]]";//17
            var queries = InputUtility.StringToIntArray2D(strQueries);
            var result = cl.MatrixSumQueries(n, queries);
            Console.WriteLine(result);
        }
    }
}
