using LeetCodeTasks.Utility;

namespace LeetCodeTasks._973KClosestPointstoOrigin
{
    public class Runner
    {
        public void Run()
        {
            //var nums = "[[1,3],[-2,2]]"; var k = 1;//[[-2,2]]
            var nums = "[[3,3],[5,-1],[-2,4]]"; var k = 2;//[[3,3],[-2,4]]
            var points = InputUtility.StringToIntArray2D(nums);
            var cl = new KClosestPointstoOrigin();
            var result = cl.KClosest(points, k);
            Console.WriteLine(ResultUtility.Array2D(result));
        }
    }
}
