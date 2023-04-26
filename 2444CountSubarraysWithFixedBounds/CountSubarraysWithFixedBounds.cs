namespace LeetCodeTasks._2444CountSubarraysWithFixedBounds
{
    public class CountSubarraysWithFixedBounds
    {
        public long CountSubarrays(int[] nums, int minK, int maxK)
        {
            long count = 0;
            var window = new Dictionary<int, int>();
            window[minK] = 0;
            window[maxK] = 0;
            var l = 0;
            for (var i = 0; i <= nums.Length; i++)
            {
                if (i == nums.Length || nums[i] < minK || nums[i] > maxK)
                {
                    var r = i - 1;
                    count += CountRange(l, r, window, minK, maxK, nums);

                    window[minK] = 0;
                    window[maxK] = 0;
                    l = i + 1;
                    continue;
                }

                if (nums[i] == minK) window[minK]++;
                if (nums[i] == maxK) window[maxK]++;
            }

            return count;
        }

        private long CountRange(int l, int r, Dictionary<int, int> window, int minK, int maxK, int[] nums)
        {
            var dp = new bool[r - l + 1, r - l + 1];
            return Dfs(l, r, window, minK, maxK, nums, l, dp);
        }

        private long Dfs(int l, int r, Dictionary<int, int> window, int minK, int maxK, int[] nums, int offset, bool[,] dp)
        {
            if (l > r) return 0;
            if (dp[l - offset, r - offset]) return 0;

            long count = 0;
            if (window[minK] > 0 && window[maxK] > 0)
            {
                if (nums[l] == minK) window[minK]--;
                if (nums[l] == maxK) window[maxK]--;

                count += Dfs(l + 1, r, window, minK, maxK, nums, offset, dp);

                if (nums[l] == minK) window[minK]++;
                if (nums[l] == maxK) window[maxK]++;

                if (nums[r] == minK) window[minK]--;
                if (nums[r] == maxK) window[maxK]--;

                count += Dfs(l, r - 1, window, minK, maxK, nums, offset, dp);

                if (nums[r] == minK) window[minK]++;
                if (nums[r] == maxK) window[maxK]++;

                count++;
            }

            dp[l - offset, r - offset] = true;
            return count;
        }
    }
}
