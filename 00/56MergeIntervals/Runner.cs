using LeetCodeTasks.Utility;

namespace LeetCodeTasks._56MergeIntervals
{
    public class Runner
    {
        public void Run()
        {
            //var strIntervals = "[[1,3],[2,6],[8,10],[15,18]]";//[[1,6],[8,10],[15,18]]
            var strIntervals = "[[1,4],[4,5]]";//[[1,5]]
            var intervals = InputUtility.StringToIntArray2D(strIntervals);
            var cl = new MergeIntervals();
            var result = cl.Merge(intervals);
            Console.WriteLine(ResultUtility.Array2D(result));
        }
    }
}
