namespace LeetCodeTasks._2379MinimumRecolorstoGetKConsecutiveBlackBlocks
{
    public class Runner
    {
        public void Run()
        {
            //var blocks = "WBBWWBBWBW";  var k = 7;//3
            var blocks = "WBWBBBW"; var k = 2;//0
            var cl = new MinimumRecolorstoGetKConsecutiveBlackBlocks();
            var result = cl.MinimumRecolors(blocks, k);
            Console.WriteLine(result);
        }
    }
}
