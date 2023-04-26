namespace LeetCodeTasks._136SingleNumber
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int[] { 2, 2, 1 };//1
            //var nums = new int[] { 4, 1, 2, 1, 2 };//4
            var nums = new int[] { 1 };//1
            var cl = new SingleNumberClass();
            var result = cl.SingleNumber(nums);
            Console.WriteLine(result);
        }
    }
}
