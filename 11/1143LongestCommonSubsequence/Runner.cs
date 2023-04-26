namespace LeetCodeTasks._1143LongestCommonSubsequence
{
    public class Runner
    {
        public void Run()
        {
            //var text1 = "abcde"; var text2 = "ace";//3
            //var text1 = "abc"; var text2 = "abc";//3
            var text1 = "abc"; var text2 = "def";//0
            var cl = new LongestCommonSubsequenceClass();
            var result = cl.LongestCommonSubsequence(text1, text2);
            Console.WriteLine(result);
        }
    }
}
