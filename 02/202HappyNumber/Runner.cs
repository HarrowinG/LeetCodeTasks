namespace LeetCodeTasks._202HappyNumber
{
    public class Runner
    {
        public void Run()
        {
            var n = 19;//true
            //var n = 2;//false
            var cl = new HappyNumber();
            var result = cl.IsHappy(n);
            Console.WriteLine(result);
        }
    }
}
