using LeetCodeTasks.Utility;

namespace LeetCodeTasks._17LetterCombinationsofaPhoneNumber
{
    public class Runner
    {
        public void Run()
        {
            //var digits = "23";//["ad","ae","af","bd","be","bf","cd","ce","cf"]
            var digits = "";//[]
            //var digits = "2";//["a","b","c"]
            var cl = new LetterCombinationsofaPhoneNumber();
            var result = cl.LetterCombinations(digits);
            Console.WriteLine(ResultUtility.List(result));
        }
    }
}
