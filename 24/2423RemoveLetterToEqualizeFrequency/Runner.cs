namespace LeetCodeTasks._2423RemoveLetterToEqualizeFrequency
{
    public class Runner
    {
        public void Run()
        {
            var word = "abcc";//true
            //var word = "aazz";//false
            //var word = "bac";//true
            //var word = "cac";//true
            var cl = new RemoveLetterToEqualizeFrequency();
            var result = cl.EqualFrequency(word);
            Console.WriteLine(result);
        }
    }
}
