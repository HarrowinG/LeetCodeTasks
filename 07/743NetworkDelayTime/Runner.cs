using LeetCodeTasks.Utility;

namespace LeetCodeTasks._743NetworkDelayTime
{
    public class Runner
    {
        public void Run()
        {
            //var strTimes = "[[2,1,1],[2,3,1],[3,4,1]]"; var n = 4; var k = 2;//2
            //var strTimes = "[[1,2,1]]"; var n = 2; var k = 1;//1
            //var strTimes = "[[1,2,1]]"; var n = 2; var k = 2;//-1
            var strTimes = "[[1,2,1],[2,3,2],[1,3,4]]"; var n = 3; var k = 1;//3
            var times = InputUtility.StringToIntArray2D(strTimes);
            var cl = new NetworkDelayTimeClass();
            var result = cl.NetworkDelayTime(times, n, k);
            Console.WriteLine(result);
        }
    }
}
