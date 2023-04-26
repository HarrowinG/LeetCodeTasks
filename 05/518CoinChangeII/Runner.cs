using LeetCodeTasks.Utility;

namespace LeetCodeTasks._518CoinChangeII
{
    public class Runner
    {
        public void Run()
        {
            var amount = 5; var strCoins = "[1,2,5]";//4
            //var amount = 3; var strCoins = "[2]";//0
            //var amount = 10; var strCoins = "[10]";//1
            var coins = InputUtility.StringToIntArray(strCoins);
            var cl = new CoinChangeII();
            var result = cl.Change(amount, coins);
            Console.WriteLine(result);
        }
    }
}
