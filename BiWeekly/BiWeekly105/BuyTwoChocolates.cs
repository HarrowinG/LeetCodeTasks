using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly105
{
    public class BuyTwoChocolates
    {
        public int BuyChoco(int[] prices, int money)
        {
            Array.Sort(prices);
            var min = prices[0] + prices[1];
            return min > money ? money : money - min;
        }
    }
}
