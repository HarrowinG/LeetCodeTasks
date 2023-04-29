using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1697CheckingExistenceofEdgeLengthLimitedPaths
{
    public class Runner
    {
        public void Run()
        {
            var cl = new CheckingExistenceofEdgeLengthLimitedPaths();
            var n = 3; var edgeListStr = "[[0,1,2],[1,2,4],[2,0,8],[1,0,16]]"; var queriesStr = "[[0,1,2],[0,2,5]]";//[false,true]
            //var n = 5; var edgeListStr = "[[0,1,10],[1,2,5],[2,3,9],[3,4,13]]"; var queriesStr = "[[0,4,14],[1,4,13]]";//[true,false]
            var edgeList = InputUtility.StringToIntArray2D(edgeListStr);
            var queries = InputUtility.StringToIntArray2D(queriesStr);
            var result = cl.DistanceLimitedPathsExist(n, edgeList, queries);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
