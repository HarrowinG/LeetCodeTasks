namespace LeetCodeTasks._746MinCostClimbingStairs
{
    public class Runner
    {
        public void Run()
        {
            //var cost = new int[] { 10, 15, 20 };//15
            var cost = new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };//6
            var cl = new MinCostClimbingStairsClass();
            var result = cl.MinCostClimbingStairs(cost);
            Console.WriteLine(result);
        }
    }
}
