namespace LeetCodeTasks._1498NumberofSubsequencesThatSatisfytheGivenSumCondition
{
    public class NumberofSubsequencesThatSatisfytheGivenSumCondition
    {
        public int NumSubseq(int[] nums, int target)
        {
            var result = 0;
            var n = nums.Length; var l = 0; var r = n - 1;
            var modulo = (int)1e9 + 7;
            Array.Sort(nums);

            var pows = new int[n];
            pows[0] = 1;
            for (var i = 1; i < n; i++)
                pows[i] = pows[i - 1] * 2 % modulo;

            while (l <= r)
            {
                if (nums[l] + nums[r] > target) r--;
                else
                {
                    result = (result + pows[r - l]) % modulo;
                    l++;
                }
            }

            return result;
        }
    }
}
