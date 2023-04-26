namespace LeetCodeTasks._30SubstringwithConcatenationofAllWords
{
    public class Runner
    {
        public void Run()
        {
            //var s = "barfoothefoobarman"; var words = new string[] { "foo", "bar" };//[0,9]
            //var s = "wordgoodgoodgoodbestword"; var words = new string[] { "word", "good", "best", "word" };//[]
            //var s = "barfoofoobarthefoobarman"; var words = new string[] { "bar", "foo", "the" };//[6,9,12]
            //var s = "wordgoodgoodgoodbestword"; var words = new string[] { "word", "good", "best", "good" };//[8]
            var s = "aaaaaaaaaaaaaa"; var words = new string[] { "aa", "aa" };//[0,1,2,3,4,5,6,7,8,9,10]
            //var s = "ababaab"; var words = new string[] { "ab", "ba", "ba" };//[1]
            //var s = "abbbabba"; var words = new string[] { "ab", "ba" };//[4]
            var cl = new SubstringwithConcatenationofAllWords();
            var listResult = cl.FindSubstring(s, words);
            var str = "[";
            foreach (var item in listResult)
            {
                str += $"{item},";
            }
            str = str.TrimEnd(',');
            str += "]";
            Console.WriteLine(str);
        }
    }
}
