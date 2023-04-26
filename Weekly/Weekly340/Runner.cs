using LeetCodeTasks.Utility;

namespace LeetCodeTasks.Weekly340
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new PrimeInDiagonal();
            //var strNums = "[[1,2,3],[5,6,7],[9,10,11]]";//11
            var strNums = "[[1,2,3],[5,17,7],[9,11,10]]";//17
            var nums = InputUtility.StringToIntArray2D(strNums);
            var result = cl.DiagonalPrime(nums);
            Console.WriteLine(result);
            */

            /*
            var cl = new SumofDistances();
            //var strNums = "[1,3,1,1,2]";//[5,0,3,4,0]
            var strNums = "[0,5,3]";//[0,0,0]
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.Distance(nums);
            Console.WriteLine(ResultUtility.Array(result));
            */

            var cl = new MinimizetheMaximumDifferenceofPairs();
            var strNums = "[10,1,2,7,1,3]"; var p = 2;//1
            //var strNums = "[4,2,1,2]"; var p = 1;//0
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.MinimizeMax(nums, p);
            Console.WriteLine(result);
        }
    }
}
