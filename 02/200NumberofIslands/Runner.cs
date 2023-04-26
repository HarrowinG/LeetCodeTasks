namespace LeetCodeTasks._200NumberofIslands
{
    public class Runner
    {
        public void Run()
        {
            /*
            var grid = new char[][]
            {
                new[]{'1', '1', '1', '1', '0'},
                new[]{'1', '1', '0', '1', '0'},
                new[]{'1', '1', '0', '0', '0'},
                new[]{'0', '0', '0', '0', '0'}
            };//1
            */
            
            var grid = new char[][]
            {
                new[]{'1', '1', '0', '0', '0'},
                new[]{'1', '1', '0', '0', '0'},
                new[]{'0', '0', '1', '0', '0'},
                new[]{'0', '0', '0', '1', '1'}
            };//3
            
            var cl = new NumberofIslands();
            var result = cl.NumIslands(grid);
            Console.WriteLine(result);
        }
    }
}
