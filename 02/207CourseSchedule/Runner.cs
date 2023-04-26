using LeetCodeTasks.Utility;

namespace LeetCodeTasks._207CourseSchedule
{
    public class Runner
    {
        public void Run()
        {
            var numCourses = 2; var strPrerequisites = "[[1,0]]";//true
            //var numCourses = 2; var strPrerequisites = "[[1,0],[0,1]]";//false
            var prerequisites = InputUtility.StringToIntArray2D(strPrerequisites);
            var cl = new CourseSchedule();
            var result = cl.CanFinish(numCourses, prerequisites);
            Console.WriteLine(result);
        }
    }
}
