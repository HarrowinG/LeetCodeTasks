namespace LeetCodeTasks._2364CountNumberofBadPairs
{
    public class CountNumberofBadPairs
    {
        public long CountBadPairs(int[] nums)
        {
            long count = 0;
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var prev = dict.GetValueOrDefault(i - nums[i], 0);
                count += prev;
                dict[i - nums[i]] = prev + 1;
            }

            return 1L * nums.Length * (nums.Length - 1) / 2 - count;
        }
    }
}
