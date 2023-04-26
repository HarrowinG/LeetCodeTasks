using LeetCodeTasks.Utility;

namespace LeetCodeTasks.Weekly338
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new KItemsWiththeMaximumSum();
            //var numOnes = 3; var numZeros = 2; var numNegOnes = 0; var k = 2;//2
            //var numOnes = 3; var numZeros = 2; var numNegOnes = 0; var k = 4;//3
            var numOnes = 1; var numZeros = 2; var numNegOnes = 2; var k = 4;//0
            var result = cl.KItemsWithMaximumSum(numOnes, numZeros, numNegOnes, k);
            Console.WriteLine(result);
            */

            var cl = new PrimeSubtractionOperation();
            //var strNums = "[4,9,6,10]";//true
            //var strNums = "[6,8,11,12]";//true
            var strNums = "[5,8,3]";//false
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.PrimeSubOperation(nums);
            Console.WriteLine(result);
        }
    }
}
