using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2426NumberofPairsSatisfyingInequality
{
    public class Runner
    {
        public void Run()
        {
            //var strNums1 = "[3,2,5]"; var strNums2 = "[2,2,1]"; var diff = 1;//3
            //var strNums1 = "[3,-1]"; var strNums2 = "[-2,2]"; var diff = -1;//0
            var strNums1 = "[-4,-4,4,-1,-2,5]"; var strNums2 = "[-2,2,-1,4,4,3]"; var diff = 1;//9
            var nums1 = InputUtility.StringToIntArray(strNums1);
            var nums2 = InputUtility.StringToIntArray(strNums2);
            var cl = new NumberofPairsSatisfyingInequality();
            var result = cl.NumberOfPairs(nums1, nums2, diff);
            Console.WriteLine(result);
        }
    }
}
