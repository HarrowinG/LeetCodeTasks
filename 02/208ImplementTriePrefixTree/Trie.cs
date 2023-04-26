namespace LeetCodeTasks._208ImplementTriePrefixTree
{
    public class TrieNode
    {
        public TrieNode()
        {
            Children = new();
        }

        public Dictionary<char, TrieNode> Children { get; set; }
        public bool EndOfWord { get; set; }
    }

    public class Trie
    {
        private TrieNode _root = new();

        public Trie() { }

        public void Insert(string word)
        {
            var trieNode = _root;
            for (int i = 0; i < word.Length; i++)
            {
                trieNode.Children[word[i]] = trieNode.Children.GetValueOrDefault(word[i], new TrieNode());
                trieNode = trieNode.Children[word[i]];
            }

            trieNode.EndOfWord = true;
        }

        public bool Search(string word)
        {
            var trieNode = _root;
            for (int i = 0; i < word.Length; i++)
            {
                if (!trieNode.Children.ContainsKey(word[i])) return false;
                trieNode = trieNode.Children[word[i]];
            }

            return trieNode.EndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            var trieNode = _root;
            for (int i = 0; i < prefix.Length; i++)
            {
                if (!trieNode.Children.ContainsKey(prefix[i])) return false;
                trieNode = trieNode.Children[prefix[i]];
            }

            return true;
        }
    }
}
