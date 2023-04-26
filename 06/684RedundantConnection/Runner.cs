using LeetCodeTasks.Utility;

namespace LeetCodeTasks._684RedundantConnection
{
    public class Runner
    {
        public void Run()
        {
            //var strEdges = "[[1,2],[1,3],[2,3]]";//[2,3]
            var strEdges = "[[1,2],[2,3],[3,4],[1,4],[1,5]]";//[1,4]
            var edges = InputUtility.StringToIntArray2D(strEdges);
            var cl = new RedundantConnection();
            var result = cl.FindRedundantConnection(edges);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
