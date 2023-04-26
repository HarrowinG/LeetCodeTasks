namespace LeetCodeTasks._1639NumberofWaystoFormaTargetStringGivenaDictionary
{
    public class Runner
    {
        public void Run()
        {
            var cl = new NumberofWaystoFormaTargetStringGivenaDictionary();
            var words = new string[] { "acca", "bbbb", "caca" }; var target = "aba";//6
            //var words = new string[] { "abba", "baab" }; var target = "bab";//4
            var result = cl.NumWays(words, target);
            Console.WriteLine(result);
        }
    }
}
