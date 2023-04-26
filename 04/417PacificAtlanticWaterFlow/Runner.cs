using LeetCodeTasks.Utility;

namespace LeetCodeTasks._417PacificAtlanticWaterFlow
{
    public class Runner
    {
        public void Run()
        {
            var nums = "[[1,2,2,3,5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5],[5,1,1,2,4]]";//[[0,4],[1,3],[1,4],[2,2],[3,0],[3,1],[4,0]]
            //var nums = "[[1]]";//[[0,0]]
            var heights = InputUtility.StringToIntArray2D(nums);
            var cl = new PacificAtlanticWaterFlow();
            var result = cl.PacificAtlantic(heights);
            Console.WriteLine(ResultUtility.List2D(result));
        }
    }
}
