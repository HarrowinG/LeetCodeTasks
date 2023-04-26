using LeetCodeTasks.Utility;

namespace LeetCodeTasks._210CourseScheduleII
{
    public class Runner
    {
        public void Run()
        {
            //var numCourses = 2; var strPrerequisites = "[[1,0]]";//[0,1]
            //var numCourses = 4; var strPrerequisites = "[[1,0],[2,0],[3,1],[3,2]]";//[0,2,1,3]
            var numCourses = 1; var strPrerequisites = "[]";//[0]
            var prerequisites = InputUtility.StringToIntArray2D(strPrerequisites);
            var cl = new CourseScheduleII();
            var result = cl.FindOrder(numCourses, prerequisites);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
