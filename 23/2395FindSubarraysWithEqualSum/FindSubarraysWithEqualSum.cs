namespace LeetCodeTasks._2395FindSubarraysWithEqualSum
{
    public class FindSubarraysWithEqualSum
    {
        public bool FindSubarrays(int[] nums)
        {
            var set = new HashSet<int>();
            for (int i = 1; i < nums.Length; i++)
            {
                var sum = nums[i] + nums[i - 1];
                if (set.Contains(sum)) return true;
                set.Add(sum);
            }

            return false;
        }
    }
}
