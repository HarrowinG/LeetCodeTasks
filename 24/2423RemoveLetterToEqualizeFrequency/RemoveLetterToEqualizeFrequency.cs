namespace LeetCodeTasks._2423RemoveLetterToEqualizeFrequency
{
    public class RemoveLetterToEqualizeFrequency
    {
        public bool EqualFrequency(string word)
        {
            var arr = new int[26];
            for (var i = 0; i < word.Length; i++)
                arr[word[i] - 'a']++;

            var set = new HashSet<char>();
            for (var i = 0; i < word.Length; i++)
            {
                if (set.Contains(word[i])) continue;
                set.Add(word[i]);

                arr[word[i] - 'a']--;
                if (new HashSet<int>(arr.Where(x => x > 0)).Count == 1) return true;

                arr[word[i] - 'a']++;
            }

            return false;
        }
    }
}
