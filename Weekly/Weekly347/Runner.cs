using LeetCodeTasks.Utility;

namespace LeetCodeTasks.Weekly347
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new DifferenceofNumberofDistinctValuesonDiagonals();
            //var strGrid = "[[1,2,3],[3,1,5],[3,2,1]]";//[[1,1,0],[1,0,1],[0,1,1]]
            var strGrid = "[[1]]";//[[0]]
            var grid = InputUtility.StringToIntArray2D(strGrid);
            var result = cl.DifferenceOfDistinctValues(grid);
            Console.WriteLine(ResultUtility.Array2D(result));
            */

            var cl = new MinimumCosttoMakeAllCharactersEqual();
            var s = "0011";//2
            //var s = "010101";//9
            var result = cl.MinimumCost(s);
            Console.WriteLine(result);
        }
    }
}
