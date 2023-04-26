namespace LeetCodeTasks._126WordLadderII
{
    public class WordLadderII
    {
        //TLE - todo
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            var result = new List<IList<string>>();
            var wordSet = new HashSet<string>(wordList);
            if (!wordSet.Contains(endWord)) return result;

            var queue = new Queue<IList<string>>();
            var verified = new HashSet<string>();
            queue.Enqueue(new List<string> { beginWord });

            var lastRun = false;
            while (queue.Count > 0)
            {
                foreach (var item in verified)
                {
                    wordSet.Remove(item);
                }
                verified.Clear();

                var n = queue.Count;
                for (var i = 0; i < n; i++)
                {
                    var sequence = queue.Dequeue();
                    foreach (var nextWord in NextWords(sequence.Last(), wordSet))
                    {
                        var nextChain = new List<string>(sequence);
                        nextChain.Add(nextWord);
                        queue.Enqueue(nextChain);
                        verified.Add(nextWord);
                        if (nextWord == endWord)
                        {
                            lastRun = true;
                            result.Add(nextChain);
                        }
                    }
                }

                if (lastRun) break;
            }

            return result;
        }

        private IList<string> NextWords(string curWord, ISet<string> wordSet)
        {
            var result = new List<string>();
            foreach (var word in wordSet)
            {
                var diffCount = 0;
                for (int i = 0; i < curWord.Length; i++)
                {
                    if (curWord[i] != word[i]) diffCount++;
                }
                if (diffCount == 1)
                {
                    result.Add(word);
                }
            }

            return result;
        }
    }
}
