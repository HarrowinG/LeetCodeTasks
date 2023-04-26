using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2421NumberofGoodPaths
{
    public class Runner
    {
        public void Run()
        {
            //var strVals = "[1,3,2,1,3]"; var strEdges = "[[0,1],[0,2],[2,3],[2,4]]";//6
            //var strVals = "[1,1,2,2,3]"; var strEdges = "[[0,1],[1,2],[2,3],[2,4]]";//7
            //var strVals = "[1]"; var strEdges = "[]";//1
            //var strVals = "[2,5,5,1,5,2,3,5,1,5]"; var strEdges = "[[0,1],[2,1],[3,2],[3,4],[3,5],[5,6],[1,7],[8,4],[9,7]]";//20
            var strVals = "[5,1,4,2,1,5,4,3]"; var strEdges = "[[1,0],[2,0],[3,2],[4,2],[5,4],[6,4],[6,7]]";//10
            var vals = InputUtility.StringToIntArray(strVals);
            var edges = InputUtility.StringToIntArray2D(strEdges);
            var cl = new NumberofGoodPaths();
            var result = cl.NumberOfGoodPaths(vals, edges);
            Console.WriteLine(result);
        }
    }
}
