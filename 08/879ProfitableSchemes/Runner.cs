using LeetCodeTasks.Utility;

namespace LeetCodeTasks._879ProfitableSchemes
{
    public class Runner
    {
        public void Run()
        {
            var cl = new ProfitableSchemesClass();
            var n = 5; var minProfit = 3; var strGroup = "[2,2]"; var strProfit = "[2,3]";//2
            //var n = 10; var minProfit = 5; var strGroup = "[2,3,5]"; var strProfit = "[6,7,8]";//7
            var group = InputUtility.StringToIntArray(strGroup);
            var profit = InputUtility.StringToIntArray(strProfit);
            var result = cl.ProfitableSchemes(n, minProfit, group, profit);
            Console.WriteLine(result);
        }
    }
}
