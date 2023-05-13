namespace LeetCodeTasks._2466CountWaysToBuildGoodStrings
{
    public class Runner
    {
        public void Run()
        {
            var cl = new CountWaysToBuildGoodStrings();
            //var low = 3; var high = 3; var zero = 1; var one = 1;//8
            var low = 2; var high = 3; var zero = 1; var one = 2;//5
            var result = cl.CountGoodStrings(low, high, zero, one);
            Console.WriteLine(result);
        }
    }
}
