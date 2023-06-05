using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1232CheckIfItIsaStraightLine
{
    public class Runner
    {
        public void Run()
        {
            var cl = new CheckIfItIsaStraightLine();
            //var strCoordinates = "[[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]";//true
            var strCoordinates = "[[1,1],[2,2],[3,4],[4,5],[5,6],[7,7]]";//false
            var coordinates = InputUtility.StringToIntArray2D(strCoordinates);
            var result = cl.CheckStraightLine(coordinates);
            Console.WriteLine(result);
        }
    }
}
