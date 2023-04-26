namespace LeetCodeTasks._2420FindAllGoodIndices
{
    public class FindAllGoodIndices
    {
        public IList<int> GoodIndices(int[] nums, int k)
        {
            var result = new List<int>();
            var dpLeft = new int[nums.Length]; dpLeft[0] = 1;
            var dpRight = new int[nums.Length]; dpRight[dpRight.Length - 1] = 1;
            for (var i = 1; i < nums.Length - k; i++)
                if (nums[i] <= nums[i - 1]) dpLeft[i] = dpLeft[i - 1] + 1;
                else dpLeft[i] = 1;

            for (var i = nums.Length - 2; i >= k; i--)
                if (nums[i] <= nums[i + 1]) dpRight[i] = dpRight[i + 1] + 1;
                else dpRight[i] = 1;

            for (var i = k; i < nums.Length - k; i++)
                if (dpLeft[i - 1] >= k && dpRight[i + 1] >= k) result.Add(i);

            return result;
        }
    }
}
