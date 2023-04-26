namespace LeetCodeTasks._647PalindromicSubstrings
{
    public class Runner
    {
        public void Run()
        {
            //var s = "abc";//3 "a", "b", "c".
            var s = "aaa";//6 "a", "a", "a", "aa", "aa", "aaa"
            var cl = new PalindromicSubstrings();
            var result = cl.CountSubstrings(s);
            Console.WriteLine(result);
        }
    }
}
