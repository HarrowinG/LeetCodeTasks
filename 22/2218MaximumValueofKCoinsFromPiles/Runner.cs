using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2218MaximumValueofKCoinsFromPiles
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MaximumValueofKCoinsFromPiles();
            var strPiles = "[[1,100,3],[7,8,9]]"; var k = 2;//101
            //var strPiles = "[[100],[100],[100],[100],[100],[100],[1,1,1,1,1,1,700]]"; var k = 7;//706
            var piles = InputUtility.StringToIntList2D(strPiles);
            var result = cl.MaxValueOfCoins(piles, k);
            Console.WriteLine(result);
        }
    }
}
