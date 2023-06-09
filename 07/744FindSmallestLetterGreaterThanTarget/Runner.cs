namespace LeetCodeTasks._744FindSmallestLetterGreaterThanTarget
{
    public class Runner
    {
        public void Run()
        {
            var cl = new FindSmallestLetterGreaterThanTarget();
            //var letters = new[] { 'c', 'f', 'j' }; var target = 'a';//c
            //var letters = new[] { 'c', 'f', 'j' }; var target = 'c';//f
            var letters = new[] { 'x', 'x', 'y', 'y' }; var target = 'z';//x
            var result = cl.NextGreatestLetter(letters, target);
            Console.WriteLine(result);
        }
    }
}
