using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1569NumberofWaystoReorderArraytoGetSameBST
{
    public class Runner
    {
        public void Run()
        {
            var cl = new NumberofWaystoReorderArraytoGetSameBST();
            //var strNums = "[2,1,3]";//1
            var strNums = "[3,4,5,1,2]";//5
            //var strNums = "[1,2,3]";//0
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.NumOfWays(nums);
            Console.WriteLine(result);
        }
    }
}
