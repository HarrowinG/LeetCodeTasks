using LeetCodeTasks.Utility;

namespace LeetCodeTasks.Weekly343
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new DeterminetheWinnerofaBowlingGame();
            //var player1Str = "[4,10,7,9]"; var player2Str = "[6,5,2,3]";//1
            //var player1Str = "[3,5,7,6]"; var player2Str = "[8,10,10,2]";//2
            var player1Str = "[2,3]"; var player2Str = "[4,1]";//0
            var player1 = InputUtility.StringToIntArray(player1Str);
            var player2 = InputUtility.StringToIntArray(player2Str);
            var result = cl.IsWinner(player1, player2);
            Console.WriteLine(result);
            */

            /*
            var cl = new FirstCompletelyPaintedRoworColumn();
            var strArr = "[1,3,4,2]"; var strMat = "[[1,4],[2,3]]";//2
            //var strArr = "[2,8,7,4,1,3,5,6,9]"; var strMat = "[[3,2,5],[1,4,6],[8,7,9]]";//3
            var arr = InputUtility.StringToIntArray(strArr);
            var mat = InputUtility.StringToIntArray2D(strMat);
            var result = cl.FirstCompleteIndex(arr, mat);
            Console.WriteLine(result);
            */

            var cl = new MinimumCostofaPathWithSpecialRoads();
            //var strStart = "[1,1]"; var strTarget = "[4,5]"; var strSpecialRoads = "[[1,2,3,3,2],[3,4,4,5,1]]";//5
            var strStart = "[3,2]"; var strTarget = "[5,7]"; var strSpecialRoads = "[[3,2,3,4,4],[3,3,5,5,5],[3,4,5,6,6]]";//7
            var strat = InputUtility.StringToIntArray(strStart);
            var target = InputUtility.StringToIntArray(strTarget);
            var specialRoads = InputUtility.StringToIntArray2D(strSpecialRoads);
            var result = cl.MinimumCost(strat, target, specialRoads);
            Console.WriteLine(result);
        }
    }
}
