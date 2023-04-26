using LeetCodeTasks.Utility;

namespace LeetCodeTasks.BiWeekly102
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new FindtheWidthofColumnsofaGrid();
            //var strGrid = "[[1],[22],[333]]";//[3]
            //var strGrid = "[[-15,1,3],[15,7,12],[5,6,-2]]";//[3,1,2]
            var strGrid = "[[0]]";//[1]
            var grid = InputUtility.StringToIntArray2D(strGrid);
            var result = cl.FindColumnWidth(grid);
            Console.WriteLine(ResultUtility.Array(result));
            */

            /*
            var cl = new FindtheScoreofAllPrefixesofanArray();
            //var strNums = "[2,3,7,5,10]";//[4,10,24,36,56]
            var strNums = "[1,1,2,4,8,16]";//[2,4,8,16,32,64]
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.FindPrefixScore(nums);
            Console.WriteLine(ResultUtility.Array(result));
            */

            /*
            var cl = new CousinsinBinaryTreeII();
            //var strRoot = "[5,4,9,1,10,null,7]";//[0,0,0,7,7,null,11]
            var strRoot = "[3,1,2]";//[0,0,0]
            var root = TreeUtility.BuildBinaryTree(InputUtility.StringToNullIntArray(strRoot));
            var result = cl.ReplaceValueInTree(root);
            Console.WriteLine(ResultUtility.BinaryTree(result));
            */

            var n = 4; var strEdges = "[[0,2,5],[0,1,2],[1,2,1],[3,0,3]]";
            //["Graph", "shortestPath", "shortestPath", "addEdge", "shortestPath"]
            //[3, 2], [0, 3], [[1, 3, 4]], [0, 3]]
            //output [null, 6, -1, null, 6]
            var edges = InputUtility.StringToIntArray2D(strEdges);
            var g = new Graph(n, edges);
            Console.WriteLine(g.ShortestPath(3, 2)); // return 6. The shortest path from 3 to 2 in the first diagram above is 3 -> 0 -> 1 -> 2 with a total cost of 3 + 2 + 1 = 6.
            Console.WriteLine(g.ShortestPath(0, 3)); // return -1. There is no path from 0 to 3.
            g.AddEdge(new int[] { 1, 3, 4 }); // We add an edge from node 1 to node 3, and we get the second diagram above.
            Console.WriteLine(g.ShortestPath(0, 3)); // return 6. The shortest path from 0 to 3 now is 0 -> 1 -> 3 with a total cost of 2 + 4 = 6.
        }
    }
}
