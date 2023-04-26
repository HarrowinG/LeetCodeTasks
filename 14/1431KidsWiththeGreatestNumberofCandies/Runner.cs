using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1431KidsWiththeGreatestNumberofCandies
{
    public class Runner
    {
        public void Run()
        {
            var cl = new KidsWiththeGreatestNumberofCandies();
            //var strCandies = "[2,3,5,1,3]"; var extraCandies = 3;//[true,true,true,false,true]
            //var strCandies = "[4,2,1,1,2]"; var extraCandies = 1;//[true,false,false,false,false]
            var strCandies = "12,1,12]"; var extraCandies = 10;//[true,false,true]
            var candies = InputUtility.StringToIntArray(strCandies);
            var result = cl.KidsWithCandies(candies, extraCandies);
            Console.WriteLine(ResultUtility.List(result));
        }
    }
}
