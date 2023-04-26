namespace LeetCodeTasks._2368ReachableNodesWithRestrictions
{
    public class Runner
    {
        public void Run()
        {
            var n = 7;
            var edges = new int[][]
            {
                new int[] { 0,1 },
                new int[] { 1,2 },
                new int[] { 3,1 },
                new int[] { 4,0 },
                new int[] { 0,5 },
                new int[] { 5,6 },
            };
            var restricted = new int[] { 4, 5 };//4
            /*
            var n = 7;
            var edges = new int[][]
            {
                new int[] { 0,1 },
                new int[] { 0,2 },
                new int[] { 0,5 },
                new int[] { 0,4 },
                new int[] { 3,2 },
                new int[] { 6,5 },
            };
            var restricted = new int[] { 4, 2, 1 };//3
            */
            var cl = new ReachableNodesWithRestrictions();
            var result = cl.ReachableNodes(n, edges, restricted);
            Console.WriteLine(result);
        }
    }
}
