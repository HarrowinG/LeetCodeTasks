using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2407LongestIncreasingSubsequenceII
{
    public class Runner
    {
        public void Run()
        {
            //var strNums = "[4,2,1,4,3,4,5,8,15]"; var k = 3;//5
            var strNums = "[7,4,5,1,8,12,4,7]"; var k = 5;//4
            //var strNums = "[1,5]"; var k = 1;//1
            //var strNums = "[1,100,500,100000,100000]"; var k = 100000;//4
            //var strNums = "[1,3,3,4]"; var k = 1;//2
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new LongestIncreasingSubsequenceII();
            var reslt = cl.LengthOfLIS(nums, k);
            Console.WriteLine(reslt);
        }
    }
}
