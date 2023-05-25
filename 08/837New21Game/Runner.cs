namespace LeetCodeTasks._837New21Game
{
    public class Runner
    {
        public void Run()
        {
            var cl = new New21GameClass();
            //int n = 10, k = 1, maxPts = 10;//1.00000
            //int n = 6, k = 1, maxPts = 10;//0.60000
            int n = 21, k = 17, maxPts = 10;//0.73278
            var result = cl.New21Game(n, k, maxPts);
            Console.WriteLine(result);
        }
    }
}
