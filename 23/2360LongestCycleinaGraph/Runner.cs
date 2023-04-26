using System;

namespace LeetCodeTasks._2360LongestCycleinaGraph
{
    public class Runner
    {
        public void Run()
        {
            //var edges = new[] { 3, 3, 4, 2, 3 };//3
            //var edges = new[] { 2, -1, 3, 1 };//-1
            var edges = new[] { 1, 2, 0, 4, 5, 6, 3, 8, 9, 7 };//4
            //var edges = new[] { -1, 4, -1, 2, 0, 4 };//-1
            var cl = new LongestCycleinaGraph();
            var result = cl.LongestCycle(edges);
            Console.WriteLine(result);
        }
    }
}
