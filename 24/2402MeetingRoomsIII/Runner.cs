using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2402MeetingRoomsIII
{
    public class Runner
    {
        public void Run()
        {
            //var n = 2; var nums = "[[0,10],[1,5],[2,7],[3,4]]";//0
            var n = 3; var nums = "[[1,20],[2,10],[3,5],[4,9],[6,8]]";//1
            var meetings = InputUtility.StringToIntArray2D(nums);
            var cl = new MeetingRoomsIII();
            var result = cl.MostBooked(n, meetings);
            Console.WriteLine(result);
        }
    }
}
