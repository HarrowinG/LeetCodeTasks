using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2389LongestSubsequenceWithLimitedSum
{
    public class Runner
    {
        public void Run()
        {
            var nums = new int[] { 4, 5, 2, 1 }; var queries = new int[] { 3, 10, 21 };//[2,3,4]
            //var nums = new int[] { 2, 3, 4, 5 }; var queries = new int[] { 1 };//[0]
            var cl = new LongestSubsequenceWithLimitedSum();
            var result = cl.AnswerQueries(nums, queries);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
