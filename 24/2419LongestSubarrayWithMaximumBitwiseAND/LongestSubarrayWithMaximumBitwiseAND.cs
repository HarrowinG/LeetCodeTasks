namespace LeetCodeTasks._2419LongestSubarrayWithMaximumBitwiseAND
{
    public class LongestSubarrayWithMaximumBitwiseAND
    {
        public int LongestSubarray(int[] nums)
        {
            var max = nums.Max();
            var res = 1;
            var length = 0;
            for (var r = 0; r < nums.Length; r++)
            {
                if (nums[r] == max) length++; //(nums[r] & max) == max maximum AND can be only with the same number!
                else length = 0;
                res = Math.Max(res, length);
            }

            return res;
        }
    }
}
