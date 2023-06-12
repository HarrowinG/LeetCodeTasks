using LeetCodeTasks.Utility;

namespace LeetCodeTasks._228SummaryRanges
{
    public class Runner
    {
        public void Run()
        {
            var cl = new SummaryRangesClass();
            //var strNums = "[0,1,2,4,5,7]";//["0->2","4->5","7"]
            var strNums = "[0,2,3,4,6,8,9]";//["0","2->4","6","8->9"]
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.SummaryRanges(nums);
            Console.WriteLine(ResultUtility.List(result));
        }
    }
}
