namespace LeetCodeTasks._53MaximumSubarray
{
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            return Kadane(nums);
        }

        private int Kadane(int[] nums)
        {
            var max = nums[0];
            var current = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                current = Math.Max(current, 0) + nums[i];
                max = Math.Max(max, current);
            }

            return max;
        }
    }
}
