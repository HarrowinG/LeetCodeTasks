using LeetCodeTasks.Utility;

namespace LeetCodeTasks._4MedianofTwoSortedArrays
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MedianofTwoSortedArrays();
            var strNums1 = "[1,3]"; var strNums2 = "[2]";//2.0
            //var strNums1 = "[1,2]"; var strNums2 = "[3,4]";//2.5
            //var strNums1 = "[1,2,3,5,5,6,7,8]"; var strNums2 = "[1,2,3,4]";//3.5
            //var strNums1 = "[1,2,3,4]"; var strNums2 = "[5]";//3
            var nums1 = InputUtility.StringToIntArray(strNums1);
            var nums2 = InputUtility.StringToIntArray(strNums2);
            var result = cl.FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine(result);
        }
    }
}
