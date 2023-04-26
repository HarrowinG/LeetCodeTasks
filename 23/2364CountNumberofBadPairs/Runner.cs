namespace LeetCodeTasks._2364CountNumberofBadPairs
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int[] { 4, 1, 3, 3 };//5
            var nums = new int[] { 1, 2, 3, 4, 5 };//0
            var cl = new CountNumberofBadPairs();
            var result = cl.CountBadPairs(nums);
            Console.WriteLine(result);
        }
    }
}
