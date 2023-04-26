namespace LeetCodeTasks._2382MaximumSegmentSumAfterRemovals
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int[] { 1, 2, 5, 6, 1 }; var removeQueries = new int[] { 0, 3, 2, 4, 1 };//14,7,2,2,0
            //var nums = new int[] { 3, 2, 11, 1 }; var removeQueries = new int[] { 3, 2, 1, 0 };//16,5,3,0
            var nums = new int[] { 297,17,213,388,926,672,43,190,314,139,108,640,890,837,858,816,417,719,143,1000,595,626,210,845,172,163,939,703,904,581,703,971,992,254,637,51,738,426,594 }; 
            var removeQueries = new int[] { 34, 28, 37, 14, 25, 7, 10, 26, 0, 21, 23, 6, 13, 35, 8, 29, 9, 32, 24, 3, 1, 30, 38, 15, 18, 36, 19, 12, 31, 33, 5, 11, 4, 20, 2, 22, 27, 17, 16 };
            //[18285,13880,13880,7348,5674,5543,5543,5543,5543,3690,3690,3690,3690,3690,3690,3690,3690,3690,3690,3690,3690,3690,3690,2874,1598,1598,1598,1598,1598,1598,1136,1136,1136,1136,1136,1136,1136,417,0]
            var cl = new MaximumSegmentSumAfterRemovals();
            var listResult = cl.MaximumSegmentSum(nums, removeQueries);
            var str = "[";
            foreach (var item in listResult)
            {
                str += $"{item},";
            }
            str = str.Trim(',');
            str += "]";
            Console.WriteLine(str);
        }
    }
}
