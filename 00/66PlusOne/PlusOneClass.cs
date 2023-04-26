namespace LeetCodeTasks._66PlusOne
{
    public class PlusOneClass
    {
        public int[] PlusOne(int[] digits)
        {
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            var res = new int[digits.Length + 1];
            res[0] = 1;

            return res;
        }
    }
}
