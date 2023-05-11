namespace LeetCodeTasks._1035UncrossedLines
{
    public class UncrossedLines
    {
        public int MaxUncrossedLines(int[] nums1, int[] nums2)
        {
            var m = nums1.Length;
            var n = nums2.Length;
            if (m < n) return MaxUncrossedLines(nums2, nums1);

            var dp = new int[n + 1];
            for (var i = m - 1; i >= 0; i--)
            {
                var current = new int[n + 1];
                for (var j = n - 1; j >= 0; j--)
                {
                    if (nums1[i] == nums2[j])
                        current[j] = dp[j + 1] + 1;
                    else
                        current[j] = Math.Max(current[j + 1], dp[j]);
                }
                dp = current;
            }

            return dp[0];
        }
    }
}
