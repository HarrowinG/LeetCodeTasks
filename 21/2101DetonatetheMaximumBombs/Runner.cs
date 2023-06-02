using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2101DetonatetheMaximumBombs
{
    public class Runner
    {
        public void Run()
        {
            var cl = new DetonatetheMaximumBombs();
            //var strBombs = "[[2,1,3],[6,1,4]]";//2
            //var strBombs = "[[1,1,5],[10,10,5]]";//1
            //var strBombs = "[[1,2,3],[2,3,1],[3,4,2],[4,5,3],[5,6,4]]";//5
            var strBombs = "[[37207,2653,5261],[40784,59523,20635],[16390,1426,39102],[42236,12,96855],[72839,62027,61667],[60691,58191,48447],[42932,46579,41248],[35868,43119,6870],[41693,98905,17374],[43441,1266,41621]]";//10
            var bombs = InputUtility.StringToIntArray2D(strBombs);
            var result = cl.MaximumDetonation(bombs);
            Console.WriteLine(result);
        }
    }
}
