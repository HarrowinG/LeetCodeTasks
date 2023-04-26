namespace LeetCodeTasks._97InterleavingString
{
    public class Runner
    {
        public void Run()
        {
            string s1 = "aabcc", s2 = "dbbca", s3 = "aadbbcbcac";//true
            //string s1 = "aabcc", s2 = "dbbca", s3 = "aadbbbaccc";//false
            //string s1 = "", s2 = "", s3 = "";//true
            var cl = new InterleavingString();
            var result = cl.IsInterleave(s1, s2, s3);
            Console.WriteLine(result);
        }
    }
}
