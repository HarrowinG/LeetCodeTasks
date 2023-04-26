using LeetCodeTasks.Utility;

namespace LeetCodeTasks._846HandofStraights
{
    public class Runner
    {
        public void Run()
        {
            var strHand = "[1,2,3,6,2,3,4,7,8]"; var groupSize = 3;//true
            //var strHand = "[1,2,3,4,5]"; var groupSize = 4;//false
            //var strHand = "[2,1]"; var groupSize = 2;//true
            var hand = InputUtility.StringToIntArray(strHand);
            var cl = new HandofStraights();
            var result = cl.IsNStraightHand(hand, groupSize);
            Console.WriteLine(result);
        }
    }
}
