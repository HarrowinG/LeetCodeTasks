namespace LeetCodeTasks._704BinarySearch
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int[] { -1, 0, 3, 5, 9, 12 }; var target = 9;//4
            var nums = new int[] { -1, 0, 3, 5, 9, 12 }; var target = 2;//-1
            var cl = new BinarySearch();
            var result = cl.Search(nums, target);
            Console.WriteLine(result);
        }
    }
}
