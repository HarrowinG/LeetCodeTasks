namespace LeetCodeTasks._2384LargestPalindromicNumber
{
    internal class Runner
    {
        public void Run()
        {
            var num = "444947137";//7449447
            //var num = "00009";//9
            //var num = "00000";//0
            var cl = new LargestPalindromicNumber();
            var result = cl.LargestPalindromic(num);
            Console.WriteLine(result);
        }
    }
}
