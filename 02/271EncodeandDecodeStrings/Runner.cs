using LeetCodeTasks.Utility;

namespace LeetCodeTasks._271EncodeandDecodeStrings
{
    public class Runner
    {
        public void Run()
        {
            //var str = new List<string> { "lint", "code", "love", "you" };
            var str = new List<string> { "we", "say", "#", "yes" };
            var cl = new EncodeandDecodeStrings();
            var encoded = cl.encode(str);
            var result = cl.decode(encoded);
            Console.WriteLine(ResultUtility.List(result));
        }
    }
}
