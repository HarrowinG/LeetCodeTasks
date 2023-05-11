using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1035UncrossedLines
{
    public class Runner
    {
        public void Run()
        {
            var cl = new UncrossedLines();
            //var strNums1 = "[1,4,2]"; var strNums2 = "[1,2,4]";//2
            //var strNums1 = "[2,5,1,2,5]"; var strNums2 = "[10,5,2,1,5,2]";//3
            var strNums1 = "[1,3,7,1,7,5]"; var strNums2 = "[1,9,2,5,1]";//2
            var nums1 = InputUtility.StringToIntArray(strNums1);
            var nums2 = InputUtility.StringToIntArray(strNums2);
            var result = cl.MaxUncrossedLines(nums1, nums2);
            Console.WriteLine(result);
        }
    }
}
