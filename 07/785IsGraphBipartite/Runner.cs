using LeetCodeTasks.Utility;

namespace LeetCodeTasks._785IsGraphBipartite
{
    public class Runner
    {
        public void Run()
        {
            var cl = new IsGraphBipartite();
            //var strGraph = "[[1,2,3],[0,2],[0,1,3],[0,2]]";//false
            var strGraph = "[[1,3],[0,2],[1,3],[0,2]]";//true
            var graph = InputUtility.StringToIntArray2D(strGraph);
            var result = cl.IsBipartite(graph);
            Console.WriteLine(result);
        }
    }
}
