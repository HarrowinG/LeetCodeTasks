using LeetCodeTasks.Utility;

namespace LeetCodeTasks.Weekly318
{
    public class Runner
    {
        public void Run()
        {
            /*
            //var strNums = "[1,2,2,1,1,0]";//[1,4,2,0,0,0]
            var strNums = "[0,1]";//[1,0]
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new _6229ApplyOperationstoanArray();
            var result = cl.ApplyOperations(nums);
            Console.WriteLine(ResultUtility.Array(result));
            */

            /*
            var strNums = "[1,5,4,2,9,9,9]"; var k = 3;//15
            //var strNums = "[4,4,4]"; var k = 3;//0
            //var strNums = "[9,9,9,1,2,3]"; var k = 3;//12
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new _6230MaximumSumofDistinctSubarraysWithLengthK();
            var result = cl.MaximumSubarraySum(nums, k);
            Console.WriteLine(result);
            */

            //var strCosts = "[17,12,10,2,7,2,11,20,8]"; var k = 3; var candidates = 4;//11
            //var strCosts = "[1,2,4,1]"; var k = 3; var candidates = 3;//4
            var strCosts = "[1,2]"; var k = 3; var candidates = 3;//3
            var costs = InputUtility.StringToIntArray(strCosts);
            var cl = new _6231TotalCosttoHireKWorkers();
            var result = cl.TotalCost(costs, k , candidates);
            Console.WriteLine(result);
        }
    }
}
