namespace LeetCodeTasks._1220CountVowelPermutation
{
    public class Runner
    {
        public void Run()
        {
            //var n = 1;//5
            //var n = 2;//10
            var n = 5;//68
            var cl = new CountVowelPermutationClass();
            var result = cl.CountVowelPermutation(n);
            Console.WriteLine(result);
        }
    }
}
