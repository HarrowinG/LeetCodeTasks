using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2399CheckDistancesBetweenSameLetters
{
    public class Runner
    {
        public void Run()
        {
            var s = "abaccb"; var nums = "[1,3,0,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]";//true
            //var s = "aa"; var nums = "[1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]";//false
            var distance = InputUtility.StringToIntArray(nums);
            var cl = new CheckDistancesBetweenSameLetters();
            var result = cl.CheckDistances(s, distance);
            Console.WriteLine(result);
        }
    }
}
