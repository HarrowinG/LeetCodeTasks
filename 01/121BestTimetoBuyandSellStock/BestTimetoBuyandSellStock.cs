namespace LeetCodeTasks._121BestTimetoBuyandSellStock
{
    public class BestTimetoBuyandSellStock
    {
        public int MaxProfit(int[] prices)
        {
            var max = 0;
            var l = 0;
            for (var r = 1; r < prices.Length; r++)
            {
                if (prices[l] > prices[r])
                {
                    l = r;
                    continue;
                }

                max = Math.Max(max, prices[r] - prices[l]);
            }

            return max;
        }
    }
}
