using System;

namespace LeetCodeTasks.StringToIntegerAtoiFolder
{
    public class StringToIntegerAtoi
    {
        public int MyAtoi(string s)
        {
            s = s.TrimStart(' ');
            var counter = 0;
            var isNegative = false;
            int result = 0;

            if (counter < s.Length)
            {
                if (s[counter] == '-')
                {
                    isNegative = true;
                    counter++;
                }
                else if (s[counter] == '+')
                {
                    counter++;
                }
            }

            while (counter < s.Length && char.IsDigit(s[counter]))
            {
                var digit = s[counter] - '0';
                if (result > (int.MaxValue - digit) / 10)
                {
                    return isNegative ? int.MinValue : int.MaxValue;
                }

                result *= 10;
                result += digit;
                counter++;
            }

            return isNegative ? -result : result;
        }
    }
}
