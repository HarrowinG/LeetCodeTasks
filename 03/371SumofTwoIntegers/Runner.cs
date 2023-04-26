namespace LeetCodeTasks._371SumofTwoIntegers
{
    public class Runner
    {
        public void Run()
        {
            var a = 1; var b = 2;//3
            //var a = 2; var b = 3;//5
            var cl = new SumofTwoIntegers();
            var result = cl.GetSum(a, b);
            Console.WriteLine(result);
        }
    }
}
