using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2438RangeProductQueriesofPowers
{
    public class Runner
    {
        public void Run()
        {
            //var n = 15; var strQueries = "[[0,1],[2,2],[0,3]]";//[2,4,64]
            //var n = 2; var strQueries = "[[0,0]]";//[2]
            var n = 919; var strQueries = "[[5,5],[4,4],[0,1],[1,5],[4,6],[6,6],[5,6],[0,3],[5,5],[5,6],[1,2],[3,5],[3,6],[5,5],[4,4],[1,1],[2,4],[4,5],[4,4],[5,6],[0,4],[3,3],[0,4],[0,5],[4,4],[5,5],[4,6],[4,5],[0,4],[6,6],[6,6],[6,6],[2,2],[0,5],[1,4],[0,3],[2,4],[5,5],[6,6],[2,2],[2,3],[5,5],[0,6],[3,3],[6,6],[4,4],[0,0],[0,2],[6,6],[6,6],[3,6],[0,4],[6,6],[2,2],[4,6]]";//[2]
            var queries = InputUtility.StringToIntArray2D(strQueries);
            var cl = new RangeProductQueriesofPowers();
            var result = cl.ProductQueries(n, queries);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
