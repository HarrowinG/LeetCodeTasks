using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2542MaximumSubsequenceScore
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MaximumSubsequenceScore();
            //var strNums1 = "[1,3,3,2]"; var strNums2 = "[2,1,3,4]"; var k = 3;//12
            //var strNums1 = "[4,2,3,1,1]"; var strNums2 = "[7,5,10,9,6]"; var k = 1;//30
            var strNums1 = "[1000,1]"; var strNums2 = "[10,10]"; var k = 1;//10000
            var nums1 = InputUtility.StringToIntArray(strNums1);
            var nums2 = InputUtility.StringToIntArray(strNums2);
            var result = cl.MaxScore(nums1, nums2, k);
            Console.WriteLine(result);
        }
    }
}
