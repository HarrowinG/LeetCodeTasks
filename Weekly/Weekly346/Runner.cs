using LeetCodeTasks.Utility;

namespace LeetCodeTasks.Weekly346
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new MinimumStringLengthAfterRemovingSubstrings();
            //var s = "ABFCACDB";//2
            var s = "ACBBD";//5
            var result = cl.MinLength(s);
            Console.WriteLine(result);
            */
            /*
            var cl = new LexicographicallySmallestPalindrome();
            //var s = "egcfe";//efcfe
            //var s = "abcd";//abba
            var s = "seven";//neven
            var result = cl.MakeSmallestPalindrome(s);
            Console.WriteLine(result);
            */
            /*
            var cl = new FindthePunishmentNumberofanInteger();
            //var n = 10;//182
            var n = 37;//1478
            var result = cl.PunishmentNumber(n);
            Console.WriteLine(result);
            */
            var cl = new ModifyGraphEdgeWeights();
            //var n = 5; var strEdges = "[[4,1,-1],[2,0,-1],[0,3,-1],[4,3,-1]]"; var source = 0; var destination = 1; var target = 5;//[[4,1,1],[2,0,1],[0,3,3],[4,3,1]]
            //var n = 3; var strEdges = "[[0,1,-1],[0,2,5]]"; var source = 0; var destination = 2; var target = 6;//[]
            var n = 4; var strEdges = "[[1,0,4],[1,2,3],[2,3,5],[0,3,-1]]"; var source = 0; var destination = 2; var target = 6;//[[1,0,4],[1,2,3],[2,3,5],[0,3,1]]
            var edges = InputUtility.StringToIntArray2D(strEdges);
            var result = cl.ModifiedGraphEdges(n, edges, source, destination, target);
            Console.WriteLine(ResultUtility.Array2D(result));
        }
    }
}
