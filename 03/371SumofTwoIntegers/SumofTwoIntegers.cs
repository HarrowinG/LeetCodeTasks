namespace LeetCodeTasks._371SumofTwoIntegers
{
    public class SumofTwoIntegers
    {
        public int GetSum(int a, int b)
        {
            while (b != 0)
            {
                var temp = (a & b) << 1;
                a ^= b;
                b = temp;
            }

            return a;
        }
    }
}
