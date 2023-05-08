using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1964FindtheLongestValidObstacleCourseatEachPosition
{
    public class Runner
    {
        public void Run()
        {
            var cl = new FindtheLongestValidObstacleCourseatEachPosition();
            //var strObstacles = "[1,2,3,2]";//[1,2,3,3]
            //var strObstacles = "[2,2,1]";//[1,2,1]
            var strObstacles = "[3,1,5,6,4,2]";//[1,1,2,3,2,2]
            var obstacles = InputUtility.StringToIntArray(strObstacles);
            var result = cl.LongestObstacleCourseAtEachPosition(obstacles);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
