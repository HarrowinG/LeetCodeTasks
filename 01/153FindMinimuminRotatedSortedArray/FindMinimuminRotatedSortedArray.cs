namespace LeetCodeTasks._153FindMinimuminRotatedSortedArray
{
    public class FindMinimuminRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            var l = 0;
            var r = nums.Length - 1;
            while (l < r)
            {
                var mid = l + (r - l) / 2;
                if (nums[mid] > nums[r]) l = mid + 1;
                else r = mid;
            }

            return nums[l];
        }
    }
}
