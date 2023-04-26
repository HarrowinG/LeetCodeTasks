namespace LeetCodeTasks._91DecodeWays
{
    public class Runner
    {
        public void Run()
        {
            var s = "12";//2
            //var s = "226";//3
            //var s = "06";//0
            //var s = "2101";//1
            //var s = "1123";//5
            var cl = new DecodeWays();
            var result = cl.NumDecodings(s);
            Console.WriteLine(result);
        }
    }
}
