namespace LeetCodeTasks._300LongestIncreasingSubsequence
{
    public class LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            //return N2(nums);
            return Bs(nums);
        }

        private int N2(int[] nums)
        {
            var dp = new int[nums.Length];
            var max = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                dp[i] = 1;
                for(int j = nums.Length - 1; j > i; j--)
                {
                    if (nums[i] < nums[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
                max = Math.Max(max, dp[i]);
            }

            return max;
        }

        private int Bs(int[] nums)
        {
            var seq = new List<int> { nums[0] };
            foreach (int num in nums)
            {
                if (num > seq[seq.Count - 1])
                {
                    seq.Add(num);
                    continue;
                }

                var index = BinarySearch(seq, num);
                seq[index] = num;
            }

            return seq.Count;
        }

        private int BinarySearch(List<int> seq, int num)
        {
            var l = 0;
            var r = seq.Count - 1;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                if (seq[mid] == num) return mid;
                else if (seq[mid] < num) l = mid + 1;
                else r = mid - 1;
            }

            return l;
        }
    }
}
