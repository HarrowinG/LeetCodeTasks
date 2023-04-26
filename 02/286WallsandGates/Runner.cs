using LeetCodeTasks.Utility;

namespace LeetCodeTasks._286WallsandGates
{
    public class Runner
    {
        public void Run()
        {
            var strRooms = "[[2147483647,-1,0,2147483647],[2147483647,2147483647,2147483647,-1],[2147483647,-1,2147483647,-1],[0,-1,2147483647,2147483647]]";//[[3,-1,0,1],[2,2,1,-1],[1,-1,2,-1],[0,-1,3,4]]
            //var strRooms = "[[0,-1],[2147483647,2147483647]]";//[[0,-1],[1,2]]
            var rooms = InputUtility.StringToIntArray2D(strRooms);
            var cl = new WallsandGates();
            cl.WallsAndGates(rooms);
            Console.WriteLine(ResultUtility.Array2D(rooms));
        }
    }
}
