namespace LeetCodeTasks._2429MinimizeXOR
{
    public class Runner
    {
        public void Run()
        {
            var num1 = 3; var num2 = 5;//3
            //var num1 = 1; var num2 = 12;//3
            var cl = new MinimizeXOR();
            var result = cl.MinimizeXor(num1, num2);
            Console.WriteLine(result);
        }
    }
}
