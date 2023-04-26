using LeetCodeTasks.Utility;

namespace LeetCodeTasks._153FindMinimuminRotatedSortedArray
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[3,4,5,1,2]";//1
            //var strNums = "[4,5,6,7,0,1,2]";//0
            //var strNums = "[11,13,15,17]";//11
            //var strNums = "[3,1,2]";//1
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new FindMinimuminRotatedSortedArray();
            var result = cl.FindMin(nums);
            Console.WriteLine(result);
        }
    }
}
