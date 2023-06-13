namespace LeetCodeTasks._2352EqualRowandColumnPairs
{
    public class EqualRowandColumnPairs
    {
        private class TrieNode
        {
            public int Value { get; set; }
            public Dictionary<int, TrieNode> Children { get; set; }
            public bool IsEnd { get; set; }
            public int Count { get; set; }

            public TrieNode()
            {
                Children = new();
            }
        }

        public int EqualPairs(int[][] grid)
        {
            var trie = new TrieNode();
            for (var j = 0; j < grid.Length; j++)
            {
                var current = trie;
                for (var i = 0;  i < grid.Length; i++)
                {
                    if (current.Children.ContainsKey(grid[i][j]))
                    {
                        current = current.Children[grid[i][j]];
                        continue;
                    }

                    var node = new TrieNode { Value = grid[i][j] };
                    current.Children[grid[i][j]] = node;
                    current = node;
                }

                current.IsEnd = true;
                current.Count++;
            }

            var result = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                var current = trie;
                for (var j = 0; j < grid.Length; j++)
                {
                    if (!current.Children.ContainsKey(grid[i][j])) break;

                    current = current.Children[grid[i][j]];
                }

                if (current.IsEnd) result += current.Count;
            }

            return result;
        }
    }
}
