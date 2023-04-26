using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1857LargestColorValueinaDirectedGraph
{
    public class Runner
    {
        public void Run()
        {
            var cl = new LargestColorValueinaDirectedGraph();
            var colors = "abaca"; var strEdges = "[[0,1],[0,2],[2,3],[3,4]]";//3
            //var colors = "a"; var strEdges = "[[0,0]]";//-1
            //var colors = "g"; var strEdges = "[]";//1
            //var colors = "aaa"; var strEdges = "[[1,2],[2,1]]";//-1
            //var colors = "ab"; var strEdges = "[[1,0],[1,1]]";//-1
            var edges = InputUtility.StringToIntArray2D(strEdges);
            var result = cl.LargestPathValue(colors, edges);
            Console.WriteLine(result);
        }
    }
}
