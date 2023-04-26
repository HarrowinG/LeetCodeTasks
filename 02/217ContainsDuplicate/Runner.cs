namespace LeetCodeTasks._217ContainsDuplicate
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int[] { 1, 2, 3, 1 };//true
            //var nums = new int[] { 1, 2, 3, 4 };//false
            var nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };//true
            var cl = new ContainsDuplicateClass();
            var result = cl.ContainsDuplicate(nums);
            Console.WriteLine(result);
        }
    }
}
