namespace LeetCodeTasks._509FibonacciNumber
{
    public class Runner
    {
        public void Run()
        {
            //var n = 2;//1
            //var n = 3;//2
            var n = 4;//3
            var cl = new FibonacciNumber();
            var result = cl.Fib(n);
            Console.WriteLine(result);
        }
    }
}
