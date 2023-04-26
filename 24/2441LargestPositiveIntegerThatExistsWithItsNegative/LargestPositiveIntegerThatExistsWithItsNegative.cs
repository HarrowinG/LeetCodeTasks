namespace LeetCodeTasks._2441LargestPositiveIntegerThatExistsWithItsNegative
{
    public class LargestPositiveIntegerThatExistsWithItsNegative
    {
        public int FindMaxK(int[] nums)
        {
            Array.Sort(nums);
            var l = 0;
            var r = nums.Length - 1;
            while (l < r)
            {
                if (nums[r] < 0 || nums[l] > 0) return -1;

                if (nums[r] == -nums[l]) return nums[r];
                else if (nums[r] > -nums[l]) r--;
                else l++;
            }

            return -1;
        }
    }
}
