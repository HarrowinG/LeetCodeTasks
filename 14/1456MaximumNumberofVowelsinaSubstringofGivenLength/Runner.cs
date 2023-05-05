namespace LeetCodeTasks._1456MaximumNumberofVowelsinaSubstringofGivenLength
{
    public class Runner
    {
        public void Run()
        {
            var cl = new MaximumNumberofVowelsinaSubstringofGivenLength();
            //var s = "abciiidef"; var k = 3;//3
            //var s = "aeiou"; var k = 2;//2
            var s = "leetcode"; var k = 3;//2
            var result = cl.MaxVowels(s, k);
            Console.WriteLine(result);
        }
    }
}
