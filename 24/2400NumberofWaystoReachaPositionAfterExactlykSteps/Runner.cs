namespace LeetCodeTasks._2400NumberofWaystoReachaPositionAfterExactlykSteps
{
    public class Runner
    {
        public void Run()
        {
            var startPos = 1; var endPos = 2; var k = 3;//3
            //var startPos = 2; var endPos = 5; var k = 10;//0
            var cl = new NumberofWaystoReachaPositionAfterExactlykSteps();
            var result = cl.NumberOfWays(startPos, endPos, k);
            Console.WriteLine(result);
        }
    }
}
