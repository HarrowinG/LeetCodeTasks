namespace LeetCodeTasks._1768MergeStringsAlternately
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MergeStringsAlternately();
            //var word1 = "abc"; var word2 = "pqr";//apbqcr
            //var word1 = "ab"; var word2 = "pqrs";//apbqrs
            var word1 = "abcd"; var word2 = "pq";//apbqcd
            var result = cl.MergeAlternately(word1, word2);
            Console.WriteLine(result);
        }
    }
}
