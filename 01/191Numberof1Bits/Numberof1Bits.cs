namespace LeetCodeTasks._191Numberof1Bits
{
    public class Numberof1Bits
    {
        public int HammingWeight(uint n)
        {
            var count = 0;
            while(n > 0)
            {
                if ((n & 1) > 0) count++;
                n >>= 1;
            }

            return count;
        }
    }
}
