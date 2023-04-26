namespace LeetCodeTasks._2413SmallestEvenMultiple
{
    public class Runner
    {
        public void Run()
        {
            var n = 5;//10
            //var n = 6;//6
            var cl = new SmallestEvenMultipleClass();
            var result = cl.SmallestEvenMultiple(n);
            Console.WriteLine(result);
        }
    }
}
