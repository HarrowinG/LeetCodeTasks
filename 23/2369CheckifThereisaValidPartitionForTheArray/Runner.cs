namespace LeetCodeTasks._2369CheckifThereisaValidPartitionForTheArray
{
    public class Runner
    {
        public void Run()
        {
            var nums = new int[] { 4, 4, 4, 5, 6 };//true
            //var nums = new int[] { 1, 1, 1, 2 };//false
            var cl = new CheckifThereisaValidPartitionForTheArray();
            var result = cl.ValidPartition(nums);
            Console.WriteLine(result);
        }
    }
}
