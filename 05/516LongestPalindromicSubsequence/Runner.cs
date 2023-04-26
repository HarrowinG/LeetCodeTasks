namespace LeetCodeTasks._516LongestPalindromicSubsequence
{
    public class Runner
    {
        public void Run()
        {
            var cl = new LongestPalindromicSubsequence();
            //var s = "bbbab";//4
            //var s = "cbbd";//2
            var s = "aplmbijcygdrdewsdtfcuhbokna";//9 "abcdedcba"
            var result = cl.LongestPalindromeSubseq(s);
            Console.WriteLine(result);
        }
    }
}
