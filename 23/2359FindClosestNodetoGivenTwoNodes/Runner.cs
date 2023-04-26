using System;

namespace LeetCodeTasks._2359FindClosestNodetoGivenTwoNodes
{
    public class Runner
    {
        public void Run()
        {
            //var edges = new[] { 2, 2, 3, -1 }; var node1 = 0; var node2 = 1; //2
            //var edges = new[] { 2, 2, 3, 0 }; var node1 = 2; var node2 = 0; //2
            //var edges = new[] { 1, 2, -1 }; var node1 = 0; var node2 = 2; //2
            //var edges = new[] { 5, -1, 3, 4, 5, 6, -1, -1, 4, 3 }; var node1 = 0; var node2 = 0; //0
            var edges = new[] { 2, 0, 0 }; var node1 = 2; var node2 = 0; //0
            var cl = new FindClosestNodetoGivenTwoNodes();
            var result = cl.ClosestMeetingNode(edges, node1, node2);
            Console.WriteLine(result);
        }
    }
}
