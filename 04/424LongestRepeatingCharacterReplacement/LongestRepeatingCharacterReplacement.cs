namespace LeetCodeTasks._424LongestRepeatingCharacterReplacement
{
    public class LongestRepeatingCharacterReplacement
    {
        public int CharacterReplacement(string s, int k)
        {
            var max = 0;
            var l = 0;
            var dict = new Dictionary<char, int>();
            var maxChar = 0;
            for (var r = 0; r < s.Length; r++)
            {
                var length = r - l + 1;
                dict[s[r]] = dict.GetValueOrDefault(s[r], 0) + 1;
                maxChar = Math.Max(maxChar, dict[s[r]]);
                while (length - maxChar > k)
                {
                    dict[s[l]]--;
                    l++;
                    length--;
                }

                max = Math.Max(max, length);
            }

            return max;
        }
    }
}
