using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2418SortthePeople
{
    public class Runner
    {
        public void Run()
        {
            var names = new string[] { "Mary", "John", "Emma" }; var strHeights = "[180,165,170]"; //["Mary","Emma","John"]
            //var names = new string[] { "Alice", "Bob", "Bob" }; var strHeights = "[155,185,150]"; //["Bob","Alice","Bob"]
            var heights = InputUtility.StringToIntArray(strHeights);
            var cl = new SortthePeople();
            var result = cl.SortPeople(names, heights);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
