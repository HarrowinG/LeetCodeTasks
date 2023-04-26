using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2406DivideIntervalsIntoMinimumNumberofGroups
{
    public class Runner
    {
        public void Run()
        {
            //var strIntervals = "[[5,10],[6,8],[1,5],[2,3],[1,10]]";//3
            var strIntervals = "[[1,3],[5,6],[8,10],[11,13]]";//1
            var intervals = InputUtility.StringToIntArray2D(strIntervals);
            var cl = new DivideIntervalsIntoMinimumNumberofGroups();
            var result = cl.MinGroups(intervals);
            Console.WriteLine(result);
        }
    }
}
