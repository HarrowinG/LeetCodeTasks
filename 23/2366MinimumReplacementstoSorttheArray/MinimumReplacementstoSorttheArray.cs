namespace LeetCodeTasks._2366MinimumReplacementstoSorttheArray
{
    public class MinimumReplacementstoSorttheArray
    {
        public long MinimumReplacement(int[] nums)
        {
            if (nums.Length == 0) return 0L;

            long numOfChanges = 0;
            var max = nums[nums.Length - 1];
            for (var i = nums.Length - 2; i >= 0; i--)
            {
                var curCount = nums[i] / max;
                if (nums[i] % max != 0)
                {
                    curCount++;
                    max = nums[i] / curCount;
                }

                numOfChanges += curCount - 1;
            }

            return numOfChanges;
        }
    }
}
