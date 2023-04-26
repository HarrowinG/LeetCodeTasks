namespace LeetCodeTasks._45JumpGameII
{
    public class JumpGameII
    {
        public int Jump(int[] nums)
        {
            var res = 0;
            var l = 0;
            var r = 0;

            while (r < nums.Length - 1)
            {
                var farthest = 0;
                for (var i = l; i <= r; i++)
                {
                    farthest = Math.Max(farthest, i + nums[i]);
                }
                l = r + 1;
                r = farthest;

                res++;
            }

            return res;
        }
    }
}
