namespace LeetCodeTasks._300LongestIncreasingSubsequence
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int[] { 10, 9, 2, 5, 3, 7, 101, 18 };//4
            //var nums = new int[] { 0, 1, 0, 3, 2, 3 };//4
            //var nums = new int[] { 7, 7, 7, 7, 7, 7, 7 };//4
            var nums = new int[] { 3, 5, 6, 2, 5, 4, 19, 5, 6, 7, 12 };//6
            var cl = new LongestIncreasingSubsequence();
            var result = cl.LengthOfLIS(nums);
            Console.WriteLine(result);
        }
    }
}
