namespace LeetCodeTasks._268MissingNumber
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int[] { 3, 0, 1 };//2
            //var nums = new int[] { 0, 1 };//2
            var nums = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };//8
            var cl = new MissingNumberClass();
            var result = cl.MissingNumber(nums);
            Console.WriteLine(result);
        }
    }
}
