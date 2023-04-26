namespace LeetCodeTasks._79WordSearch
{
    public class Runner
    {
        public void Run()
        {
            var board = new char[][] 
            {
                new char[]{'A', 'B', 'C', 'E'},
                new char[]{'S', 'F', 'C', 'S'},
                new char[]{'A', 'D', 'E', 'E'}
            };
            var word = "ABCCED";//true
            //var word = "SEE";//true
            //var word = "ABCB";//false
            var cl = new WordSearch();
            var result = cl.Exist(board, word);
            Console.WriteLine(result);
        }
    }
}
