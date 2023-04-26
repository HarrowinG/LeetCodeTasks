namespace LeetCodeTasks._746MinCostClimbingStairs
{
    public class MinCostClimbingStairsClass
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            for (int i = cost.Length - 3; i >= 0; i--)
            {
                cost[i] += Math.Min(cost[i + 1], cost[i + 2]);
            }

            return Math.Min(cost[0], cost[1]);
        }
    }
}
