namespace LeetCodeTasks._211DesignAddandSearchWordsDataStructure
{
    public class WordDictionary
    {
        private class TrieNode
        {
            public bool IsFinal { get; set; }
            public Dictionary<char, TrieNode> Children { get; set; }

            public TrieNode()
            {
                Children = new Dictionary<char, TrieNode>();
            }
        }

        private TrieNode _trie;

        public WordDictionary()
        {
            _trie = new TrieNode();
        }

        public void AddWord(string word)
        {
            var trie = _trie;
            foreach (var c in word)
            {
                if (!trie.Children.ContainsKey(c))
                    trie.Children[c] = new TrieNode();

                trie = trie.Children[c];
            }

            trie.IsFinal = true;
        }

        public bool Search(string word)
        {
            return Search(word, 0, _trie);
        }

        private bool Search(string word, int index, TrieNode trie)
        {
            for (var i = index; i < word.Length; i++)
            {
                var c = word[i];
                if (c == '.')
                {
                    foreach (var kvp in trie.Children)
                    {
                        if (Search(word, i + 1, kvp.Value))
                            return true;
                    }

                    return false;
                }

                if (!trie.Children.ContainsKey(c)) return false;

                trie = trie.Children[c];
            }

            return trie.IsFinal;
        }
    }
}
