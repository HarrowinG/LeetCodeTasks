using System.Collections.Generic;

namespace LeetCodeTasks.RomanToIntsFolder
{
    public class RomanToInts
    {
        private readonly Dictionary<string, int> _dictionary = new Dictionary<string, int>
        {
            ["I"] = 1,
            ["IV"] = 4,
            ["IX"] = 9,
            ["V"] = 5,
            ["X"] = 10,
            ["XL"] = 40,
            ["XC"] = 90,
            ["L"] = 50,
            ["C"] = 100,
            ["CD"] = 400,
            ["CM"] = 900,
            ["D"] = 500,
            ["M"] = 1000,
        };

        public int RomanToInt(string s)
        {
            if (s.Length == 1)
            {
                return _dictionary[s];
            }

            var sum = 0;
            var counter = 0;
            while (counter < s.Length)
            {
                if (counter + 1 < s.Length && _dictionary.TryGetValue($"{s[counter]}{s[counter + 1]}", out int result))
                {
                    sum += result;
                    counter += 2;
                }
                else
                {
                    sum += _dictionary[$"{s[counter]}"];
                    counter++;
                }
            }

            return sum;
        }
    }
}
