namespace LeetCodeTasks._49GroupAnagrams
{
    public class Runner
    {
        public void Run()
        {
            //var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };//[["bat"],["nat","tan"],["ate","eat","tea"]]
            //var strs = new string[] { "" };//[[""]]
            var strs = new string[] { "a" };//[["a"]]
            var cl = new GroupAnagramsClass();
            var listListResult = cl.GroupAnagrams(strs);
            var str = "[";
            foreach (var listResult in listListResult)
            {
                str += "[";
                foreach(var item in listResult)
                {
                    str += $"{item},";
                }
                str = str.TrimEnd(',');
                str += "]";
            }
            str = str.TrimEnd(',');
            str += "]";
            Console.WriteLine(str);
        }
    }
}
