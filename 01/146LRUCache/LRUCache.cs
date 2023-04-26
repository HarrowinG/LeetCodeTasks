namespace LeetCodeTasks._146LRUCache
{
    public class LRUCache
    {
        private class DoubleLinkedNode
        {
            public int Key { get; set; }
            public int Val { get; set; }
            public DoubleLinkedNode Next { get; set; }
            public DoubleLinkedNode Prev { get; set; }
        }

        private readonly int _capacity;
        private DoubleLinkedNode _head;
        private DoubleLinkedNode _tail;
        private Dictionary<int, DoubleLinkedNode> _dict = new();

        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _head = new DoubleLinkedNode();
            _tail = new DoubleLinkedNode();
            _head.Next = _tail;
            _tail.Prev = _head;
        }

        private void Remove(DoubleLinkedNode node)
        {
            var prev = node.Prev;
            var next = node.Next;
            prev.Next = next;
            next.Prev = prev;
        }

        private void Insert(DoubleLinkedNode node)
        {
            var prev = _tail.Prev;
            prev.Next = node;
            node.Prev = prev;
            node.Next = _tail;
            _tail.Prev = node;
        }

        public int Get(int key)
        {
            if (!_dict.ContainsKey(key)) return -1;

            Remove(_dict[key]);
            Insert(_dict[key]);

            return _dict[key].Val;
        }

        public void Put(int key, int value)
        {
            if (_dict.ContainsKey(key)) Remove(_dict[key]);

            _dict[key] = new DoubleLinkedNode { Key = key, Val = value };
            Insert(_dict[key]);

            if (_dict.Count > _capacity)
            {
                var lru = _head.Next;
                Remove(lru);
                _dict.Remove(lru.Key);
            }
        }
    }
}
