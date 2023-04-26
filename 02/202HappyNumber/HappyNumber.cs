namespace LeetCodeTasks._202HappyNumber
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            //return Set(n);
            return Floyd(n);
        }

        private bool Set(int n)
        {
            var set = new HashSet<int>();
            while (!set.Contains(n))
            {
                set.Add(n);
                n = DigitSquareSum(n);
            }

            return n == 1;
        }

        private bool Floyd(int n)
        {
            var slow = n;
            var fast = DigitSquareSum(n);
            while (slow != fast)
            {
                slow = DigitSquareSum(slow);
                fast = DigitSquareSum(fast);
                fast = DigitSquareSum(fast);
            }

            return slow == 1;
        }

        private int DigitSquareSum(int n)
        {
            int sum = 0, tmp;
            while (n > 0)
            {
                tmp = n % 10;
                sum += tmp * tmp;
                n /= 10;
            }
            return sum;
        }
    }
}
