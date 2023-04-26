namespace LeetCodeTasks._647PalindromicSubstrings
{
    public class PalindromicSubstrings
    {
        public int CountSubstrings(string s)
        {
            var result = 0;
            for (var i = 0; i < s.Length; i++)
            {
                result += CheckPalindrom(s, i, i);
                result += CheckPalindrom(s, i, i + 1);
            }

            return result;
        }

        private int CheckPalindrom(string s, int l, int r)
        {
            var count = 0;
            while (l >= 0 && r < s.Length)
            {
                if (s[l] != s[r]) break;

                l--;
                r++;
                count++;
            }

            return count;
        }
    }
}
