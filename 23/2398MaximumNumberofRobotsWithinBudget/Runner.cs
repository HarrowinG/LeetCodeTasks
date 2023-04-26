using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2398MaximumNumberofRobotsWithinBudget
{
    public class Runner
    {
        public void Run()
        {
            var times = "[3,6,1,3,4]"; var costs = "[2,1,3,4,5]"; var budget = 25;//3
            //var times = "[11,12,19]"; var costs = "[10,8,7]"; var budget = 19;//0
            var chargeTimes = InputUtility.StringToIntArray(times);
            var runningCosts = InputUtility.StringToIntArray(costs);
            var cl = new MaximumNumberofRobotsWithinBudget();
            var result = cl.MaximumRobots(chargeTimes, runningCosts, budget);
            Console.WriteLine(result);
        }
    }
}
