namespace LeetCodeTasks._2405OptimalPartitionofString
{
    public class Runner
    {
        public void Run()
        {
            var s = "abacaba";//4
            //var s = "ssssss";//6
            var cl = new OptimalPartitionofString();
            var result = cl.PartitionString(s);
            Console.WriteLine(result);
        }
    }
}
