using LeetCodeTasks.Utility;

namespace LeetCodeTasks._875KokoEatingBananas
{
    public class Runner
    {
        public void Run()
        {
            var piles = "[3,6,7,11]"; var h = 8;//4
            //var piles = "[30,11,23,4,20]"; var h = 5;//30
            //var piles = "[30,11,23,4,20]"; var h = 6;//23
            //var piles = "[312884470]"; var h = 312884469;//2
            var cl = new KokoEatingBananas();
            var result = cl.MinEatingSpeed(InputUtility.StringToIntArray(piles), h);
            Console.WriteLine(result);
        }
    }
}
