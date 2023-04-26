using LeetCodeTasks.Utility;

namespace LeetCodeTasks._57InsertInterval
{
    public class Runner
    {
        public void Run()
        {
            var strIntervals = "[[1,3],[6,9]]"; var strNewInterval = "[2,5]";//[[1,5],[6,9]]
            //var strIntervals = "[[1,2],[3,5],[6,7],[8,10],[12,16]]"; var strNewInterval = "[4,8]";//[[1,2],[3,10],[12,16]]
            var intervals = InputUtility.StringToIntArray2D(strIntervals);
            var newInterval = InputUtility.StringToIntArray(strNewInterval);
            var cl = new InsertInterval();
            var result = cl.Insert(intervals, newInterval);
            Console.WriteLine(ResultUtility.Array2D(result));
        }
    }
}
