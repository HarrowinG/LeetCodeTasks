namespace LeetCodeTasks._649Dota2Senate
{
    public class Runner
    {
        public void Run()
        {
            var cl = new Dota2Senate();
            //var senate = "RD";//Radiant
            var senate = "RDD";//Dire
            var result = cl.PredictPartyVictory(senate);
            Console.WriteLine(result);
        }
    }
}
