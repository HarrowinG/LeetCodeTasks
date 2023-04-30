using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1579RemoveMaxNumberofEdgestoKeepGraphFullyTraversable
{
    public class Runner
    {
        public void Run()
        {
            var cl = new RemoveMaxNumberofEdgestoKeepGraphFullyTraversable();
            //var n = 4; var strEdges = "[[3,1,2],[3,2,3],[1,1,3],[1,2,4],[1,1,2],[2,3,4]]";//2
            //var n = 4; var strEdges = "[[3,1,2],[3,2,3],[1,1,4],[2,1,4]]";//0
            var n = 4; var strEdges = "[[3,2,3],[1,1,2],[2,3,4]]";//-1
            var edges = InputUtility.StringToIntArray2D(strEdges);
            var result = cl.MaxNumEdgesToRemove(n, edges);
            Console.WriteLine(result);
        }
    }
}
