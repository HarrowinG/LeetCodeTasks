namespace LeetCodeTasks._2391MinimumAmountofTimetoCollectGarbage
{
    public class Runner
    {
        public void Run()
        {
            var garbage = new string[] { "G", "P", "GP", "GG" }; var travel = new int[] { 2, 4, 3 };//21
            //var garbage = new string[] { "MMM", "PGM", "GP" }; var travel = new int[] { 3, 10 };//37
            var cl = new MinimumAmountofTimetoCollectGarbage();
            var result = cl.GarbageCollection(garbage, travel);
            Console.WriteLine(result);
        }
    }
}
