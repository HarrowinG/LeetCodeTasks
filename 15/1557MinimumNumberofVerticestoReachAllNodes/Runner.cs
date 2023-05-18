using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1557MinimumNumberofVerticestoReachAllNodes
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MinimumNumberofVerticestoReachAllNodes();
            //var n = 6; var strEdges = "[[0,1],[0,2],[2,5],[3,4],[4,2]]";//[0,3]
            var n = 5; var strEdges = "[[0,1],[2,1],[3,1],[1,4],[2,4]]";//[0,2,3]
            var edges = InputUtility.StringToIntArray2D(strEdges);
            var result = cl.FindSmallestSetOfVertices(n, edges);
            Console.WriteLine(ResultUtility.List(result));
        }
    }
}
