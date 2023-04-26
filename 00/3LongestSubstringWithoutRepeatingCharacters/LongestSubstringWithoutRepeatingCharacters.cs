namespace LeetCodeTasks._3LongestSubstringWithoutRepeatingCharacters
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length < 2) return s.Length;

            var max = 0;
            var l = 0;
            var set = new HashSet<char>();

            for (var r = 0; r < s.Length; r++)
            {
                while (set.Contains(s[r]))
                {
                    set.Remove(s[l]);
                    l++;
                }
                set.Add(s[r]);
                max = Math.Max(max, set.Count);
            }

            return max;
        }
    }
}
