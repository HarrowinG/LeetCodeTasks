namespace LeetCodeTasks._2411SmallestSubarraysWithMaximumBitwiseOR
{
    public class SmallestSubarraysWithMaximumBitwiseOR
    {
        public int[] SmallestSubarrays(int[] nums)
        {
            var result = new int[nums.Length];
            var closest = new int[30];//enough bits for 10^9
            for (var i = nums.Length - 1; i >= 0; i--)
            {
                result[i] = 1;
                for (var j = 0; j < 30; j++)
                {
                    if ((nums[i] & (1 << j)) > 0)
                    {
                        closest[j] = i;
                    }
                    result[i] = Math.Max(result[i], closest[j] - i + 1);
                }
            }

            return result;
        }
    }
}
