namespace LeetCodeTasks._2376CountSpecialIntegers
{
    public class Runner
    {
        public void Run()
        {
            //var n = 20;//19
            //var n = 5;//5
            //var n = 135;//110
            var n = 2424;//1424
            var cl = new CountSpecialIntegers();
            var result = cl.CountSpecialNumbers(n);
            Console.WriteLine(result);
        }
    }
}
