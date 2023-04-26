namespace LeetCodeTasks._2374NodeWithHighestEdgeScore
{
    public class Runner
    {
        public void Run()
        {
            //var edges = new int[] { 1, 0, 0, 0, 0, 7, 7, 5 };//7
            var edges = new int[] { 2, 0, 0, 2 };//0
            var cl = new NodeWithHighestEdgeScore();
            var result = cl.EdgeScore(edges);
            Console.WriteLine(result);
        }
    }
}
