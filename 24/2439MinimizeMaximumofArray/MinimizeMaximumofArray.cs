namespace LeetCodeTasks._2439MinimizeMaximumofArray
{
    public class MinimizeMaximumofArray
    {
        public int MinimizeArrayValue(int[] nums)
        {
            long sum = 0, res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                res = Math.Max(res, (sum + i) / (i + 1)); //sum + i make integer division Ceil
            }
            return (int)res;
        }
    }
}
