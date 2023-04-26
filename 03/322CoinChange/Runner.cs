using LeetCodeTasks.Utility;

namespace LeetCodeTasks._322CoinChange
{
    public class Runner
    {
        public void Run()
        {
            //var nums = "[1,2,5]"; var amount = 11;//3
            //var nums = "[2]"; var amount = 3;//-1
            var nums = "[1]"; var amount = 0;//0
            var coins = InputUtility.StringToIntArray(nums);
            var cl = new CoinChangeClass();
            var result = cl.CoinChange(coins, amount);
            Console.WriteLine(result);
        }
    }
}
