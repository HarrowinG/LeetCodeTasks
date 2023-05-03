using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2215FindtheDifferenceofTwoArrays
{
    public class Runner
    {
        public void Run()
        {
            var cl = new FindtheDifferenceofTwoArrays();
            //var strNums1 = "[1,2,3]"; var strNums2 = "[2,4,6]";//[[1,3],[4,6]]
            var strNums1 = "[1,2,3,3]"; var strNums2 = "[1,1,2,2]";//[[3],[]]
            var nums1 = InputUtility.StringToIntArray(strNums1);
            var nums2 = InputUtility.StringToIntArray(strNums2);
            var result = cl.FindDifference(nums1, nums2);
            Console.WriteLine(ResultUtility.List2D(result));
        }
    }
}
