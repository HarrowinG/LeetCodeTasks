namespace LeetCodeTasks._621TaskScheduler
{
    public class Runner
    {
        public void Run()
        {
            //var tasks = new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }; var n = 2;//8
            //var tasks = new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }; var n = 0;//6
            var tasks = new char[] { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'C', 'D', 'E', 'F', 'G' }; var n = 2;//16
            var cl = new TaskScheduler();
            var result = cl.LeastInterval(tasks, n);
            Console.WriteLine(result);
        }
    }
}
