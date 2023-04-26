namespace LeetCodeTasks._5LongestPalindromicSubstring
{
    public class Runner
    {
        public void Run()
        {
            //var s = "babad";//bab
            var s = "cbbd";//bb
            var cl = new LongestPalindromicSubstring();
            var result = cl.LongestPalindrome(s);
            Console.WriteLine(result);
        }
    }
}
