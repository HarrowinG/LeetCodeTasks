namespace LeetCodeTasks._1312MinimumInsertionStepstoMakeaStringPalindrome
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MinimumInsertionStepstoMakeaStringPalindrome();
            var s = "zzazz";//0
            //var s = "mbadm";//2
            //var s = "leetcode";//5
            var result = cl.MinInsertions(s);
            Console.WriteLine(result);
        }
    }
}
