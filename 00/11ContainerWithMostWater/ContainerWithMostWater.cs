namespace LeetCodeTasks._11ContainerWithMostWater
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var result = 0;
            var l = 0;
            var r = height.Length - 1;
            while (l < r)
            {
                if (height[l] > height[r])
                {
                    result = Math.Max(result, height[r] * (r - l));
                    r--;
                }
                else
                {
                    result = Math.Max(result, height[l] * (r - l));
                    l++;
                }
            }

            return result;
        }
    }
}
