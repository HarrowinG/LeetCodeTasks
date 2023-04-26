namespace LeetCodeTasks._2443SumofNumberandItsReverse
{
    public class SumofNumberandItsReverse
    {
        public bool SumOfNumberAndReverse(int num)
        {
            for (var i = num; i >= 0; i--)
                if (i + Reverse(i) == num) return true;

            return false;
        }

        private int Reverse(int n)
        {
            var result = 0;
            for (; n > 0; n /= 10)
                result = result * 10 + n % 10;
            return result;
        }
    }
}
