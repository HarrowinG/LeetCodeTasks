namespace LeetCodeTasks._2366MinimumReplacementstoSorttheArray
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int[] { 3, 9, 3 };//2
            //var nums = new int[] { 1, 2, 3, 4, 5 };//0
            //var nums = new int[] { 3, 1, 1 };//2
            var nums = new int[] { 12, 9, 7, 6, 17, 19, 21 };//6
            var cl = new MinimumReplacementstoSorttheArray();
            var result = cl.MinimumReplacement(nums);
            Console.WriteLine(result);
        }
    }
}
