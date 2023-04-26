namespace LeetCodeTasks._50Powxn
{
    public class Runner
    {
        public void Run()
        {
            var x = 2.0; var n = 10;//1024.0
            //var x = 2.1; var n = 3;//9.261
            //var x = 2.0; var n = -2;//0.25
            var cl = new Powxn();
            var result = cl.MyPow(x, n);
            Console.WriteLine(result);
        }
    }
}
