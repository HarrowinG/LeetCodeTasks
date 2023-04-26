using LeetCodeTasks.Utility;

namespace LeetCodeTasks._309BestTimetoBuyandSellStockwithCooldown
{
    public class Runner
    {
        public void Run()
        {
            var strPrices = "[1,2,3,0,2]";//3
            //var strPrices = "[1]";//0
            var prices = InputUtility.StringToIntArray(strPrices);
            var cl = new BestTimetoBuyandSellStockwithCooldown();
            var result = cl.MaxProfit(prices);
            Console.WriteLine(result);
        }
    }
}
