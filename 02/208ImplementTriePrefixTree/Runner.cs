namespace LeetCodeTasks._208ImplementTriePrefixTree
{
    public class Runner
    {
        public void Run()
        {
            var cl = new Trie();
            cl.Insert("apple");
            Console.WriteLine(cl.Search("apple"));   // return True
            Console.WriteLine(cl.Search("app"));     // return False
            Console.WriteLine(cl.StartsWith("app")); // return True
            cl.Insert("app");
            Console.WriteLine(cl.Search("app"));     // return True
        }
    }
}
