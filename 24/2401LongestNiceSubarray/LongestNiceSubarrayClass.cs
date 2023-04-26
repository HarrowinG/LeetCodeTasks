namespace LeetCodeTasks._2401LongestNiceSubarray
{
    public class LongestNiceSubarrayClass
    {
        public int LongestNiceSubarray(int[] nums)
        {
            var max = 1;
            var l = 0;
            var sum = nums[0];
            for (var r = 1; r < nums.Length; r++)
            {
                while ((sum & nums[r]) != 0)
                {
                    sum ^= nums[l];
                    l++;
                }

                sum |= nums[r];
                max = Math.Max(max, r - l + 1);
            }

            return max;
        }
    }
}
