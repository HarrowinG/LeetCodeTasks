using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2397MaximumRowsCoveredbyColumns
{
    public class Runner
    {
        public void Run()
        {
            //var nums = "[[0,0,0],[1,0,1],[0,1,1],[0,0,1]]"; var cols = 2;//3
            //var nums = "[[1],[0]]"; var cols = 1;//2
            var nums = "[[1,0,1,1,1,1],[0,0,0,1,1,0],[1,1,0,0,0,0],[0,0,1,1,0,1]]"; var cols = 2;//1
            var mat = InputUtility.StringToIntArray2D(nums);
            var cl = new MaximumRowsCoveredbyColumns();
            var result = cl.MaximumRows(mat, cols);
            Console.WriteLine(result);
        }
    }
}
