using System.Numerics;

namespace LeetCodeTasks._2429MinimizeXOR
{
    public class MinimizeXOR
    {
        public int MinimizeXor(int num1, int num2)
        {
            var num1BitCount = BitOperations.PopCount((uint)num1);
            var num2BitCount = BitOperations.PopCount((uint)num2);
            var res = num1;
            for (int i = 0; i < 32; i++)
            {
                if (num1BitCount > num2BitCount && ((1 << i) & num1) > 0)
                {
                    res ^= 1 << i;
                    num1BitCount--;
                }
                if (num1BitCount < num2BitCount && ((1 << i) & num1) == 0)
                {
                    res ^= 1 << i;
                    num1BitCount++;
                }
            }

            return res;
        }
    }
}
