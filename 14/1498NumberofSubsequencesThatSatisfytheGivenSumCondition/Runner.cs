using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1498NumberofSubsequencesThatSatisfytheGivenSumCondition
{
    public class Runner
    {
        public void Run()
        {
            var cl = new NumberofSubsequencesThatSatisfytheGivenSumCondition();
            //var strNums = "[3,5,6,7]"; var target = 9;//4
            //var strNums = "[3,3,6,8]"; var target = 10;//6
            var strNums = "[2,3,3,4,6,7]"; var target = 12;//61
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.NumSubseq(nums, target);
            Console.WriteLine(result);
        }
    }
}
