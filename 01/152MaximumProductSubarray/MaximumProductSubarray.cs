namespace LeetCodeTasks._152MaximumProductSubarray
{
    public class MaximumProductSubarray
    {
        public int MaxProduct(int[] nums)
        {
            var result = nums[0];
            var min = 1;
            var max = 1;
            for (var i = 0; i < nums.Length; i++)
            {
                var temp = max;
                max = Math.Max(nums[i], Math.Max(nums[i] * max, nums[i] * min));
                min = Math.Min(nums[i], Math.Min(nums[i] * temp, nums[i] * min));
                result = Math.Max(result, max);
            }

            return result;
        }
    }
}
