namespace LeetCodeTasks._15ThreeSum
{
    public class ThreeSumClass
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);
            for (var i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                var target = 0 - nums[i];
                var l = i + 1;
                var r = nums.Length - 1;
                while (l < r)
                {
                    var sum = nums[l] + nums[r];
                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[l], nums[r] });
                        l++;
                        while (l < r && nums[l] == nums[l - 1]) l++;
                        r--;
                        while (l < r && nums[r] == nums[r + 1]) r--;
                    }
                    else if (sum < target) l++;
                    else r--;
                }
            }

            return result;
        }
    }
}
