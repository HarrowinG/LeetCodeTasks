namespace LeetCodeTasks._138CopyListwithRandomPointer
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }

    public class CopyListwithRandomPointer
    {
        public Node CopyRandomList(Node head)
        {
            var dict = new Dictionary<Node, Node>();
            return Dfs(head, dict);
        }

        private Node Dfs(Node root, Dictionary<Node, Node> dict)
        {
            if (root == null) return null;

            var node = new Node(root.val);
            dict[root] = node;
            var item = Dfs(root.next, dict);
            node.next = item;
            if (root.random != null) node.random = dict[root.random];
            return node;
        }
    }
}
