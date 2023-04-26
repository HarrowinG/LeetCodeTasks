using System.Linq;

namespace LeetCodeTasks.RichestCustomerWealthFolder
{
    public class RichestCustomerWealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            var max = 0;
            foreach (var account in accounts)
            {
                var currentSum = account.Sum();

                if (currentSum > max)
                {
                    max = currentSum;
                }
            }

            return max;
        }
    }
}
