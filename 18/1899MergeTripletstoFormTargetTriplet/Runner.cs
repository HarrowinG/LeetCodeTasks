using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1899MergeTripletstoFormTargetTriplet
{
    public class Runner
    {
        public void Run()
        {
            //var strTriplets = "[[2,5,3],[1,8,4],[1,7,5]]"; var strTarget = "[2,7,5]";//true
            //var strTriplets = "[[3,4,5],[4,5,6]]"; var strTarget = "[3,2,5]";//false
            var strTriplets = "[[2,5,3],[2,3,4],[1,2,5],[5,2,3]]"; var strTarget = "[5,5,5]";//true
            var triplets = InputUtility.StringToIntArray2D(strTriplets);
            var target = InputUtility.StringToIntArray(strTarget);
            var cl = new MergeTripletstoFormTargetTriplet();
            var result = cl.MergeTriplets(triplets, target);
            Console.WriteLine(result);
        }
    }
}
