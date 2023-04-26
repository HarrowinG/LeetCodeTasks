namespace LeetCodeTasks._62UniquePaths
{
    public class Runner
    {
        public void Run()
        {
            int m = 3; int n = 7;//28
            //int m = 3; int n = 2;//3
            var cl = new UniquePathsClass();
            var result = cl.UniquePaths(m, n);
            Console.WriteLine(result);
        }
    }
}
