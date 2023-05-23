using LeetCodeTasks.Utility;

namespace LeetCodeTasks._703KthLargestElementinaStream
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[4,5,8,2]"; var k = 3; var strAdds = "[3,5,10,9,4]";//4,5,5,8,8
            var nums = InputUtility.StringToIntArray(strNums);
            var adds = InputUtility.StringToIntArray(strAdds);
            var cl = new KthLargest(k, nums);
            var result = new List<int>();
            foreach (var item in adds)
                result.Add(cl.Add(item));

            Console.WriteLine(ResultUtility.List(result));
        }
    }
}
