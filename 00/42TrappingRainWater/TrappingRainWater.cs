namespace LeetCodeTasks._42TrappingRainWater
{
    public class TrappingRainWater
    {
        public int Trap(int[] height)
        {
            var result = 0;
            var l = 0; var r = height.Length - 1;
            var maxL = height[l]; var maxR = height[r];
            while (l < r)
            {
                if (maxL <= maxR)
                {
                    l++;
                    maxL = Math.Max(maxL, height[l]);
                    result += maxL - height[l];
                    continue;
                }

                r--;
                maxR = Math.Max(maxR, height[r]);
                result += maxR - height[r];
            }

            return result;
        }
    }
}
