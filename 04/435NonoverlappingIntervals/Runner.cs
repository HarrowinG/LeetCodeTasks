using LeetCodeTasks.Utility;

namespace LeetCodeTasks._435NonoverlappingIntervals
{
    public class Runner
    {
        public void Run()
        {
            var strIntervals = "[[1,2],[2,3],[3,4],[1,3]]";//1
            //var strIntervals = "[[1,2],[1,2],[1,2]]";//2
            //var strIntervals = "[[1,2],[2,3]]";//0
            var intervals = InputUtility.StringToIntArray2D(strIntervals);
            var cl = new NonoverlappingIntervals();
            var result = cl.EraseOverlapIntervals(intervals);
            Console.WriteLine(result);
        }
    }
}
