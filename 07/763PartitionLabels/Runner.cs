using LeetCodeTasks.Utility;

namespace LeetCodeTasks._763PartitionLabels
{
    public class Runner
    {
        public void Run()
        {
            var s = "ababcbacadefegdehijhklij";//[9,7,8]
            //var s = "eccbbbbdec";//[10]
            var cl = new PartitionLabelsClass();
            var result = cl.PartitionLabels(s);
            Console.WriteLine(ResultUtility.List(result));
        }
    }
}
