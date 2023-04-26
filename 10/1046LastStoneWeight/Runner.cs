using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1046LastStoneWeight
{
    public class Runner
    {
        public void Run()
        {
            var strStones = "[2,7,4,1,8,1]";//1
            //var strStones = "[1]";//1
            var stones = InputUtility.StringToIntArray(strStones);
            var cl = new LastStoneWeightClass();
            var result = cl.LastStoneWeight(stones);
            Console.WriteLine(result);
        }
    }
}
