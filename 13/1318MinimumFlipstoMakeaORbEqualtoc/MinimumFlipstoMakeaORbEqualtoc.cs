namespace LeetCodeTasks._1318MinimumFlipstoMakeaORbEqualtoc
{
    public class MinimumFlipstoMakeaORbEqualtoc
    {
        public int MinFlips(int a, int b, int c)
        {
            int result = 0, ab = a | b, equal = ab ^ c;
            for (int i = 0; i < 31; i++)
            {
                var mask = 1 << i;
                if ((equal & mask) > 0)
                    result += (a & mask) == (b & mask) && (c & mask) == 0 ? 2 : 1;
            }

            return result;
        }
    }
}
