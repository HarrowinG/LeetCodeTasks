namespace LeetCodeTasks._2375ConstructSmallesNumberFromDIString
{
    public class Runner
    {
        public void Run()
        {
            //var pattern = "IIIDIDDD";//123549876
            var pattern = "4321";//4321
            var cl = new ConstructSmallesNumberFromDIString();
            var result = cl.SmallestNumber(pattern);
            Console.WriteLine(result);
        }
    }
}
