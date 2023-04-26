using System.Text;

namespace LeetCodeTasks._2384LargestPalindromicNumber
{
    public class LargestPalindromicNumber
    {
        public string LargestPalindromic(string num)
        {
            var dict = new SortedDictionary<char, int>();
            foreach (char c in num)
            {
                dict[c] = dict.GetValueOrDefault(c, 0) + 1;
            }

            var singles = new HashSet<char>();
            var sb = new StringBuilder();

            foreach (var key in dict.Keys)
            {
                if (dict[key] % 2 != 0)
                {
                    singles.Add(key);
                }

                var count = dict[key];
                while (count > 1)
                {
                    sb.Append(key);
                    sb.Insert(0, key);
                    count -= 2;
                }
            }

            if (singles.Count > 0)
            {
                sb.Insert(sb.Length / 2, singles.Max());
            }

            var res = sb.ToString().Trim('0');

            return res.Length == 0 ? "0" : res;
        }
    }
}
