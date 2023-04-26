namespace LeetCodeTasks._2414LengthoftheLongestAlphabeticalContinuousSubstring
{
    public class LengthoftheLongestAlphabeticalContinuousSubstring
    {
        public int LongestContinuousSubstring(string s)
        {
            var max = 1;
            var l = 0;
            for (var r = 1; r < s.Length; r++)
            {
                if (s[r] != s[l] + r - l) l = r;
                max = Math.Max(max, r - l + 1);
            }

            return max;
        }
    }
}
