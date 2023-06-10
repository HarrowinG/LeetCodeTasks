namespace LeetCodeTasks.BiWeekly106
{
    public class Runner
    {
        public void Run()
        {
            var cl = new FindtheLongestSemiRepetitiveSubstring();
            //var s = "52233";//4
            //var s = "5494";//4
            //var s = "1111111";//2
            var s = "0010";//4
            var result = cl.LongestSemiRepetitiveSubstring(s);
            Console.WriteLine(result);
        }
    }
}
