using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2412MinimumMoneyRequiredBeforeTransactions
{
    public class Runner
    {
        public void Run()
        {
            var strtransactions = "[[2,1],[5,0],[4,2]]";//10
            //var strtransactions = "[[3,0],[0,3]]";//3
            var transactions = InputUtility.StringToIntArray2D(strtransactions);
            var cl = new MinimumMoneyRequiredBeforeTransactions();
            var result = cl.MinimumMoney(transactions);
            Console.WriteLine(result);
        }
    }
}
