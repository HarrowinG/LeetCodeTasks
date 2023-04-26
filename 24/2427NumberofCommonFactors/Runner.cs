namespace LeetCodeTasks._2427NumberofCommonFactors
{
    public class Runner
    {
        public void Run()
        {
            //var a = 12; var b = 6;//4
            var a = 25; var b = 30;//2
            var cl = new NumberofCommonFactors();
            var result = cl.CommonFactors(a, b);
            Console.WriteLine(result);
        }
    }
}
