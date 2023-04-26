namespace LeetCodeTasks._125ValidPalindrome
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            var l = 0; var r = s.Length - 1;
            while (l <= r)
            {
                while (l < r && !char.IsLetter(s[l]) && !char.IsDigit(s[l])) l++;
                while (r > l && !char.IsLetter(s[r]) && !char.IsDigit(s[r])) r--;

                if (char.ToLower(s[l]) != char.ToLower(s[r])) return false;
                l++;
                r--;
            }

            return true;
        }
    }
}
