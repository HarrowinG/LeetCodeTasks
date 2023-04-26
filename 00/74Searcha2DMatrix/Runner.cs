using LeetCodeTasks.Utility;

namespace LeetCodeTasks._74Searcha2DMatrix
{
    public class Runner
    {
        public void Run()
        {
            //var strMatrix = "[[1,3,5,7],[10,11,16,20],[23,30,34,60]]"; var target = 3;//true
            //var strMatrix = "[[1,3,5,7],[10,11,16,20],[23,30,34,60]]"; var target = 13;//false
            //var strMatrix = "[[1],[3]]"; var target = 2;//false
            var strMatrix = "[[1],[3]]"; var target = 1;//true
            //var strMatrix = "[[1],[3]]"; var target = 3;//true
            var cl = new Searcha2DMatrix();
            var result = cl.SearchMatrix(InputUtility.StringToIntArray2D(strMatrix), target);
            Console.WriteLine(result);
        }
    }
}
