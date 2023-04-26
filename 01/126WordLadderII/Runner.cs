namespace LeetCodeTasks._126WordLadderII
{
    public class Runner
    {
        public void Run()
        {
            var beginWord = "hit"; var endWord = "cog"; var wordList = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };
            //[["hit","hot","dot","dog","cog"],["hit","hot","lot","log","cog"]]
            //var beginWord = "hit"; var endWord = "cog"; var wordList = new List<string> { "hot", "dot", "dog", "lot", "log" };
            //[]
            var cl = new WordLadderII();
            var listListResult = cl.FindLadders(beginWord, endWord, wordList);
            var str = "[";
            foreach (var listResult in listListResult)
            {
                str += "[";
                foreach (var item in listResult)
                {
                    str += $"{item},";
                }

                str = str.TrimEnd(',');
                str += "],";
            }
            str = str.TrimEnd(',');
            str += "]";
            Console.WriteLine(str);
        }
    }
}
