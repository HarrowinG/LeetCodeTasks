namespace LeetCodeTasks._55JumpGame
{
    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            var target = nums.Length - 1;
            for (var i = nums.Length - 2; i >= 0; i--)
            {
                if (i + nums[i] >= target) target = i;
            }

            return target == 0;
        }
    }
}
