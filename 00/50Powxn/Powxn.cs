namespace LeetCodeTasks._50Powxn
{
    public class Powxn
    {
        public double MyPow(double x, int n)
        {
            return n >= 0 ? Raise(x, n) : 1.0 / Raise(x, -n);
        }

        private double Raise(double x, int n)
        {
            if (n == 0) return 1.0;
            if (x == 0) return 0.0;

            var res = Raise(x * x, n / 2);
            if (n % 2 == 0) return res;
            else return x * res;
        }
    }
}
