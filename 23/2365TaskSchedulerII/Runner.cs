namespace LeetCodeTasks._2365TaskSchedulerII
{
    public class Runner
    {
        public void Run()
        {
            //var tasks = new int[] { 1, 2, 1, 2, 3, 1 }; var space = 3; //9
            var tasks = new int[] { 5, 8, 8, 5 }; var space = 2; //6
            var cl = new TaskSchedulerIIClass();
            var result = cl.TaskSchedulerII(tasks, space);
            Console.WriteLine(result);
        }
    }
}
