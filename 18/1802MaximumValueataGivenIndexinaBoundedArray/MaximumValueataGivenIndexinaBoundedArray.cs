namespace LeetCodeTasks._1802MaximumValueataGivenIndexinaBoundedArray
{
    public class MaximumValueataGivenIndexinaBoundedArray
    {
        public int MaxValue(int n, int index, int maxSum)
        {
            maxSum -= n;
            int left = 0, right = maxSum, mid;
            while (left < right)
            {
                mid = left + (right - left + 1) / 2;
                if (Test(n, index, mid) <= maxSum) 
                    left = mid;
                else  right = mid - 1;
            }

            return left + 1;
        }

        private long Test(int n, int index, int a)
        {
            int b = Math.Max(a - index, 0);
            long res = (long)(a + b) * (a - b + 1) / 2;
            b = Math.Max(a - ((n - 1) - index), 0);
            res += (long)(a + b) * (a - b + 1) / 2;
            return res - a;
        }
    }
}
