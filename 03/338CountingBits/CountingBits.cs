namespace LeetCodeTasks._338CountingBits
{
    public class CountingBits
    {
        public int[] CountBits(int n)
        {
            return Count(n);
            //return CountDp(n);
        }

        private int[] CountDp(int n)
        {
            var dp = new int[n + 1];
            var offset = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i == offset << 1)
                {
                    offset = i;
                }

                dp[i] = dp[i - offset] + 1;
            }

            return dp;
        }

        private int[] Count(int n)
        {
            var res = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                var counter = 0;
                var num = i;
                while (num > 0)
                {
                    if ((num & 1) == 1) counter++; 
                    num >>= 1;
                }

                res[i] = counter;
            }

            return res;
        }
    }
}