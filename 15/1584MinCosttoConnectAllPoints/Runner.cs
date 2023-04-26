using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1584MinCosttoConnectAllPoints
{
    public class Runner
    {
        public void Run()
        {
            //var strPoints = "[[0,0],[2,2],[3,10],[5,2],[7,0]]";//20
            var strPoints = "[[3,12],[-2,5],[-4,1]]";//18
            var points = InputUtility.StringToIntArray2D(strPoints);
            var cl = new MinCosttoConnectAllPoints();
            var result = cl.MinCostConnectPoints(points);
            Console.WriteLine(result);
        }
    }
}
