using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2440CreateComponentsWithSameValue
{
    public class Runner
    {
        public void Run()
        {
            //var strNums = "[6,2,2,2,6]"; var strEdges = "[[0,1],[1,2],[1,3],[3,4]]";//2
            var strNums = "[2]"; var strEdges = "[]";//0
            var nums = InputUtility.StringToIntArray(strNums);
            var edges = InputUtility.StringToIntArray2D(strEdges);
            var cl = new CreateComponentsWithSameValue();
            var result = cl.ComponentValue(nums, edges);
            Console.WriteLine(result);
        }
    }
}
