namespace LeetCodeTasks._2367NumberofArithmeticTriplets
{
    public class Runner
    {
        public void Run()
        {
            var nums = new int[] { 0, 1, 4, 6, 7, 10 }; var diff = 3;//2
            //var nums = new int[] { 4, 5, 6, 7, 8, 9 }; var diff = 2;//2
            var cl = new NumberofArithmeticTriplets();
            var result = cl.ArithmeticTriplets(nums, diff);
            Console.WriteLine(result);
        }
    }
}
