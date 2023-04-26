using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2404MostFrequentEvenElement
{
    public class Runner
    {
        public void Run()
        {
            var strNums = "[0,1,2,2,4,4,1]";//2
            //var strNums = "[4,4,4,9,2,4]";//4
            //var strNums = "[29,47,21,41,13,37,25,7]";//-1
            var nums = InputUtility.StringToIntArray(strNums);
            var cl = new MostFrequentEvenElement();
            var result = cl.MostFrequentEven(nums);
            Console.WriteLine(result);
        }
    }
}
