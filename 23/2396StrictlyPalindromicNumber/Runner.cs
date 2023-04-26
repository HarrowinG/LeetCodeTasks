namespace LeetCodeTasks._2396StrictlyPalindromicNumber
{
    public class Runner
    {
        public void Run()
        {
            //var n = 9;//false
            var n = 4;//false
            var cl = new StrictlyPalindromicNumber();
            var result = cl.IsStrictlyPalindromic(n);
            Console.WriteLine(result);
        }
    }
}
