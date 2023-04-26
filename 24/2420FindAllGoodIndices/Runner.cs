using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2420FindAllGoodIndices
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[2,1,1,1,3,4,1]"; var k = 2;//[2,3]
            //var strNums = "[2,1,1,2]"; var k = 2;//[]
            //var strNums = "[878724,201541,179099,98437,35765,327555,475851,598885,849470,943442]"; var k = 4;//[4,5]
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new FindAllGoodIndices();
            var result = cl.GoodIndices(nums, k);
            Console.WriteLine(ResultUtility.List(result));
        }
    }
}
