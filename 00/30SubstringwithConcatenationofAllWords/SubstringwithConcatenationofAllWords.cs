namespace LeetCodeTasks._30SubstringwithConcatenationofAllWords
{
    public class SubstringwithConcatenationofAllWords
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            var wordLength = words[0].Length;
            var windowLength = words.Length * wordLength;
            if (windowLength > s.Length) return new List<int>();

            var wordTimes = new Dictionary<string, int>();
            foreach (var word in words)
            {
                wordTimes[word] = wordTimes.GetValueOrDefault(word, 0) + 1;
            }

            var result = new List<int>();
            var i = 0;
            while (i + windowLength <= s.Length)
            {
                var dict = new Dictionary<string, int>();
                var matched = true;
                for (var left = i; left < i + windowLength; left += wordLength)
                {
                    var subStr = s.Substring(left, wordLength);
                    if (!wordTimes.ContainsKey(subStr))
                    {
                        matched = false;
                        break;
                    }
                    else
                    {
                        dict[subStr] = dict.GetValueOrDefault(subStr, 0) + 1;
                        if (dict[subStr] > wordTimes[subStr])
                        {
                            matched = false;
                            break;
                        }
                    }
                }

                if (matched) result.Add(i);
                i++;
            }

            return result;
        }
    }
}
