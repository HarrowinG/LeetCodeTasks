namespace LeetCodeTasks._71SimplifyPath
{
    public class Runner
    {
        public void Run()
        {
            var cl = new SimplifyPathClass();
            //var path = "/home/";//"/home"
            //var path = "/../";//"/"
            //var path = "/home//foo/";//"/home/foo"
            var path = "////..../home/home2/home3//..//////./../////.";//"/..../home"
            var result = cl.SimplifyPath(path);
            Console.WriteLine(result);
        }
    }
}
