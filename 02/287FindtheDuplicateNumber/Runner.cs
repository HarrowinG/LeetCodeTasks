using LeetCodeTasks.Utility;

namespace LeetCodeTasks._287FindtheDuplicateNumber
{
    public class Runner
    {
        public void Run()
        {
            //var strNums = "[1,3,4,2,2]";//2
            var strNums = "[3,1,3,4,2]";//3
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new FindtheDuplicateNumber();
            var result = cl.FindDuplicate(nums);
            Console.WriteLine(result);
        }
    }
}
