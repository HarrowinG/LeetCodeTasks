using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2410MaximumMatchingofPlayersWithTrainers
{
    public class Runner
    {
        public void Run()
        {
            var strplayers = "[4, 7, 9]"; var strtrainers = "[8, 2, 5, 8]";//2
            //var strplayers = "[1,1,1]"; var strtrainers = "[10]";//1
            var players = InputUtility.StringToIntArray(strplayers);
            var trainers = InputUtility.StringToIntArray(strtrainers);
            var cl = new MaximumMatchingofPlayersWithTrainers();
            var result = cl.MatchPlayersAndTrainers(players, trainers);
            Console.WriteLine(result);
        }
    }
}
