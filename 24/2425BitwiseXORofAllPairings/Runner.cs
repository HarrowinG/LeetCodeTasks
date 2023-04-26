using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2425BitwiseXORofAllPairings
{
    public class Runner
    {
        public void Run()
        {
            var strNums1 = "[2,1,3]"; var strNums2 = "[10,2,5,0]";//13
            //var strNums1 = "[1,2]"; var strNums2 = "[3,4]";//0
            var nums1 = InputUtility.StringToIntArray(strNums1);
            var nums2 = InputUtility.StringToIntArray(strNums2);
            var cl = new BitwiseXORofAllPairings();
            var result = cl.XorAllNums(nums1, nums2);
            Console.WriteLine(result);
        }
    }
}
