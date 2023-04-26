namespace LeetCodeTasks._133CloneGraph
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }

    public class CloneGraphClass
    {
        public Node CloneGraph(Node node)
        {
            if (node == null) return null;
            var dict = new Dictionary<Node, Node> { [node] = new Node(node.val) };
            var queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var originalNode = queue.Dequeue();
                foreach (var neighbor in originalNode.neighbors)
                {
                    if (!dict.ContainsKey(neighbor))
                    {
                        dict[neighbor] = new Node(neighbor.val);
                        queue.Enqueue(neighbor);
                    }

                    dict[originalNode].neighbors.Add(dict[neighbor]);
                }
            }

            return dict[node];
        }
    }
}
