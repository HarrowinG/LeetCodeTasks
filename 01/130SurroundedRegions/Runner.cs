using LeetCodeTasks.Utility;

namespace LeetCodeTasks._130SurroundedRegions
{
    public class Runner
    {
        public void Run()
        {
            
            var board = new char[][] 
            {
                new []{'X', 'X', 'X', 'X'},
                new []{'X', 'O', 'O', 'X'},
                new []{'X', 'X', 'O', 'X'},
                new []{'X', 'O', 'X', 'X'}
            };//[["X","X","X","X"],["X","X","X","X"],["X","X","X","X"],["X","O","X","X"]]
            
            /*
            var board = new char[][]
            {
                new []{'X'}
            };//[["X"]]
            */
            var cl = new SurroundedRegions();
            cl.Solve(board);
            Console.WriteLine(ResultUtility.Array2D(board));
        }
    }
}
