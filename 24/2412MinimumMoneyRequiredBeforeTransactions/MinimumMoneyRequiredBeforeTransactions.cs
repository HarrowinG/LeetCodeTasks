namespace LeetCodeTasks._2412MinimumMoneyRequiredBeforeTransactions
{
    public class MinimumMoneyRequiredBeforeTransactions
    {
        public long MinimumMoney(int[][] transactions)
        {
            var result = 0L;
            var cost = 0;
            var cashback = 0;
            foreach (var transaction in transactions)
            {
                if (transaction[0] > transaction[1])
                {
                    result += transaction[0] - transaction[1];
                    cashback = Math.Max(cashback, transaction[1]);//get back max cashback, when it last transaction it can't return bonus
                }
                else
                {
                    cost = Math.Max(cost, transaction[0]);//when cost less than cashback we need max cost in case we start from it
                }
            }

            return result + Math.Max(cost, cashback);
        }
    }
}
