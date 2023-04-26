namespace LeetCodeTasks._2389LongestSubsequenceWithLimitedSum
{
    public class LongestSubsequenceWithLimitedSum
    {
        public int[] AnswerQueries(int[] nums, int[] queries)
        {
            var res = new int[queries.Length];
            Array.Sort(nums);
            var prefixSum = new int[nums.Length];
            prefixSum[0] = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + nums[i];
            }

            for (var q = 0; q < queries.Length; q++)
            {
                var l = 0; var r = nums.Length - 1;
                while (l <= r)
                {
                    var mid = l + (r - l) / 2;
                    if (prefixSum[mid] > queries[q]) r = mid - 1;
                    else l = mid + 1;
                }

                res[q] = l;
            }

            return res;
        }
    }
}
