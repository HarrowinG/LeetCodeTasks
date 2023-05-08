using LeetCodeTasks.Utility;

namespace LeetCodeTasks.Weekly344
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new FindtheDistinctDifferenceArray();
            var strNums = "[1,2,3,4,5]";//[-3,-1,1,3,5]
            //var strNums = "[3,2,3,4,2]";//[-2,-1,0,2,3]
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.DistinctDifferenceArray(nums);
            Console.WriteLine(ResultUtility.Array(result));
            */

            /*
            var frequencyTracker = new FrequencyTracker();
            
            frequencyTracker.Add(3); // The data structure now contains [3]
            frequencyTracker.Add(3); // The data structure now contains [3, 3]
            Console.WriteLine(frequencyTracker.HasFrequency(2)); // Returns true, because 3 occurs twice
            
            
            frequencyTracker.Add(1); // The data structure now contains [1]
            frequencyTracker.DeleteOne(1); // The data structure becomes empty []
            Console.WriteLine(frequencyTracker.HasFrequency(1)); // Returns false, because the data structure is empty
            

            Console.WriteLine(frequencyTracker.HasFrequency(2)); // Returns false, because the data structure is empty
            frequencyTracker.Add(3); // The data structure now contains [3]
            Console.WriteLine(frequencyTracker.HasFrequency(1)); // Returns true, because 3 occurs once
            */

            /*
            var cl = new NumberofAdjacentElementsWiththeSameColor();
            //var n = 4; var strQueries = "[[0,2],[1,2],[3,1],[1,1],[2,1]]";//[0,1,1,0,2]
            var n = 1; var strQueries = "[[0,100000]]";//[0]
            var queries = InputUtility.StringToIntArray2D(strQueries);
            var result = cl.ColorTheArray(n, queries);
            Console.WriteLine(ResultUtility.Array(result));
            */

            
            var cl = new MakeCostsofPathsEqualinaBinaryTree();
            var n = 7; var strCost = "[1,5,2,2,3,3,1]";//6
            //var n = 3; var strCost = "[5,3,3]";//0
            var cost = InputUtility.StringToIntArray(strCost);
            var result = cl.MinIncrements(n, cost);
            Console.WriteLine(result);
            
        }
    }
}
