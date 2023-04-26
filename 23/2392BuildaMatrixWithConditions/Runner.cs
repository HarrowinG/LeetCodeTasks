using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2392BuildaMatrixWithConditions
{
    public class Runner
    {
        public void Run()
        {
            
            var k = 3;
            var rowConditions = new int[][]
            {
                new[] {1,2},
                new[] {3,2},
            };
            var colConditions = new int[][]
            {
                new[] {2,1},
                new[] {3,2},
            };//[[3,0,0],[0,0,1],[0,2,0]]
            
            /*
            var k = 3;
            var rowConditions = new int[][]
            {
                new[] {1,2},
                new[] {2,3},
                new[] {3,1},
                new[] {2,3},
            };
            var colConditions = new int[][]
            {
                new[] {2,1},
            };//[]
            */
            var cl = new BuildaMatrixWithConditions();
            var result = cl.BuildMatrix(k, rowConditions, colConditions);
            Console.WriteLine(ResultUtility.Array2D(result));
        }
    }
}
