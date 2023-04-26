namespace LeetCodeTasks._238ProductofArrayExceptSelf
{
    public class ProductofArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var n = nums.Length;
            var result = new int[n];
            var mult = 1;
            for (int i = 0; i < n; i++)
            {
                result[i] = mult;
                mult *= nums[i];
            }
            mult = 1;
            for (var i = n - 1; i >= 0; i--)
            {
                result[i] *= mult;
                mult *= nums[i];
            }

            return result;
        }
    }
}
