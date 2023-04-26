namespace LeetCodeTasks._121BestTimetoBuyandSellStock
{
    public class Runner
    {
        public void Run()
        {
            //var prices = new int[] { 7, 1, 5, 3, 6, 4 };//5
            var prices = new int[] { 7, 6, 4, 3, 1 };//0
            var cl = new BestTimetoBuyandSellStock();
            var result = cl.MaxProfit(prices);
            Console.WriteLine(result);
        }
    }
}
