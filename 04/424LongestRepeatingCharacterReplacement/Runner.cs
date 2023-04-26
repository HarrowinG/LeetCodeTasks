namespace LeetCodeTasks._424LongestRepeatingCharacterReplacement
{
    public class Runner
    {
        public void Run()
        {
            //var s = "ABAB"; var k = 2;//4
            var s = "AABABBA"; var k = 1;//4
            var cl = new LongestRepeatingCharacterReplacement();
            var result = cl.CharacterReplacement(s, k);
            Console.WriteLine(result);
        }
    }
}
