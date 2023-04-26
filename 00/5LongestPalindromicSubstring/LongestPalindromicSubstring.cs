namespace LeetCodeTasks._5LongestPalindromicSubstring
{
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            var result = s[0].ToString();
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (result.Length / 2 > s.Length - i) break;

                var str = Expose(s, i, i);
                if (str.Length > result.Length) result = str;
                str = Expose(s, i, i + 1);
                if (str.Length > result.Length) result = str;
            }

            return result;
        }

        private string Expose(string s, int l, int r)
        {
            while (l >= 0 && r < s.Length)
            {
                if (s[l] != s[r]) break;

                l--;
                r++;
            }
            l++;
            r--;

            return s.Substring(l, r - l + 1);
        }
    }
}
