using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2416SumofPrefixScoresofStrings
{
    public class Runner
    {
        public void Run()
        {
            var words = new string[] { "abc", "ab", "bc", "b" };//[5,4,3,2]
            //var words = new string[] { "abcd" };//[4]
            var cl = new SumofPrefixScoresofStrings();
            var result = cl.SumPrefixScores(words);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
