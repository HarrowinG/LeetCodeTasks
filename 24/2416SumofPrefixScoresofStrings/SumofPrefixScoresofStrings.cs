namespace LeetCodeTasks._2416SumofPrefixScoresofStrings
{
    public class SumofPrefixScoresofStrings
    {
        private class TrieNode
        {
            public int Count { get; set; }
            public TrieNode[] Children { get; set; }
            public TrieNode()
            {
                Children = new TrieNode[26];
            }
        }

        private class Trie
        {
            private TrieNode _root = new();

            public void Insert(string s)
            {
                var node = _root;
                foreach (char c in s)
                {
                    var id = c - 'a';
                    if (node.Children[id] == null) node.Children[id] = new TrieNode();
                    node.Children[id].Count++;
                    node = node.Children[id];
                }
            }

            public int GetPrefixCount(string s)
            {
                var count = 0;
                var node = _root;
                foreach (char c in s)
                {
                    var id = c - 'a';
                    node = node.Children[id];
                    count += node.Count;
                }

                return count;
            }
        }

        public int[] SumPrefixScores(string[] words)
        {
            var result = new int[words.Length];
            var trie = new Trie();
            foreach (var word in words)
            {
                trie.Insert(word);
            }

            for (var i = 0; i < words.Length; i++)
            {
                result[i] = trie.GetPrefixCount(words[i]);
            }

            return result;
        }
    }
}
