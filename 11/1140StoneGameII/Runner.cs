using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1140StoneGameII
{
    public class Runner
    {
        public void Run()
        {
            var cl = new StoneGameIIClass();
            var strPiles = "[2,7,9,4,4]";//10
            //var strPiles = "[1,2,3,4,5,100]";//104
            var piles = InputUtility.StringToIntArray(strPiles);
            var result = cl.StoneGameII(piles);
            Console.WriteLine(result);
        }
    }
}
