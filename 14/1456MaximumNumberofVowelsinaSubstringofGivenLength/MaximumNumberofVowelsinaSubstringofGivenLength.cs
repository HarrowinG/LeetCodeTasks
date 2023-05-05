namespace LeetCodeTasks._1456MaximumNumberofVowelsinaSubstringofGivenLength
{
    public class MaximumNumberofVowelsinaSubstringofGivenLength
    {
        public int MaxVowels(string s, int k)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            var currentCount = 0;
            for (var i = 0; i < k; i++)
                if (vowels.Contains(s[i]))
                    currentCount++;

            var max = currentCount;
            for (var i = k; i < s.Length; i++)
            {
                if (currentCount == k) return k;

                if (vowels.Contains(s[i])) currentCount++;
                if (vowels.Contains(s[i - k])) currentCount--;

                max = Math.Max(max, currentCount);
            }

            return max;
        }
    }
}
