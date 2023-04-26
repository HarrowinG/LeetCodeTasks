namespace LeetCodeTasks._70ClimbingStairs
{
    public class Runner
    {
        public void Run()
        {
            //var n = 2;//2
            var n = 3;//3
            var cl = new ClimbingStairs();
            var result = cl.ClimbStairs(n);
            Console.WriteLine(result);
        }
    }
}
