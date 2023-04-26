namespace LeetCodeTasks._2386FindtheKSumofanArray
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int[] { 2, 4, -2 }; var k = 5;//2
            var nums = new int[] { 1, -2, 3, 4, -10, 12 }; var k = 16;//10
            var cl = new FindtheKSumofanArray();
            var result = cl.KSum(nums, k);
            Console.WriteLine(result);
        }
    }
}
