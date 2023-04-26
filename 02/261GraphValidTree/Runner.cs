using LeetCodeTasks.Utility;

namespace LeetCodeTasks._261GraphValidTree
{
    public class Runner
    {
        public void Run()
        {
            //var n = 5; var strEdges = "[[0,1],[0,2],[0,3],[1,4]]";//true
            var n = 5; var strEdges = "[[0,1],[1,2],[2,3],[1,3],[1,4]]";//false
            var edges = InputUtility.StringToIntArray2D(strEdges);
            var cl = new GraphValidTree();
            var result = cl.ValidTree(n, edges);
            Console.WriteLine(result);
        }
    }
}
