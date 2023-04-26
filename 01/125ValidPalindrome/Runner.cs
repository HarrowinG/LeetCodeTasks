namespace LeetCodeTasks._125ValidPalindrome
{
    public class Runner
    {
        public void Run()
        {
            var s = "A man, a plan, a canal: Panama";//true
            //var s = "race a car";//false
            //var s = " ";//true
            var cl = new ValidPalindrome();
            var result = cl.IsPalindrome(s);
            Console.WriteLine(result);
        }
    }
}
