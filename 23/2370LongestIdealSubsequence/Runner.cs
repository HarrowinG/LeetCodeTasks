namespace LeetCodeTasks._2370LongestIdealSubsequence
{
    public class Runner
    {
        public void Run()
        {
            //var s = "acfgbd"; var k = 2;//4
            //var s = "abcd"; var k = 3;//4
            var s = "pvjcci"; var k = 4;//2
            var cl = new LongestIdealSubsequence();
            var result = cl.LongestIdealString(s, k);
            Console.WriteLine(result);
        }
    }
}
