namespace LeetCodeTasks._1318MinimumFlipstoMakeaORbEqualtoc
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MinimumFlipstoMakeaORbEqualtoc();
            int a = 2, b = 6, c = 5;//3
            //int a = 4, b = 2, c = 7;//1
            //int a = 1, b = 2, c = 3;//0
            var result = cl.MinFlips(a, b, c);
            Console.WriteLine(result);
        }
    }
}
