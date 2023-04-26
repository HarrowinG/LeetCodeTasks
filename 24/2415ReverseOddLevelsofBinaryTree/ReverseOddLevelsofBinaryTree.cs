using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2415ReverseOddLevelsofBinaryTree
{
    public class ReverseOddLevelsofBinaryTree
    {
        public TreeNode ReverseOddLevels(TreeNode root)
        {
            if (root.left == null) return root;

            var queue = new Queue<List<TreeNode>>();
            queue.Enqueue(new List<TreeNode> { root.left, root.right });

            var level = 1;
            while (queue.Count > 0)
            {
                var nodes = queue.Dequeue();
                var list = new List<TreeNode>();
                if (nodes[0].left != null)
                {
                    for (var i = 0; i < nodes.Count; i++)
                    {
                        list.Add(nodes[i].left);
                        list.Add(nodes[i].right);
                    }

                    queue.Enqueue(list);
                }

                if (level % 2 == 0)
                {
                    level++;
                    continue;
                }

                for (var i = 0; i < nodes.Count / 2; i++)
                {
                    var temp = nodes[i].val;
                    nodes[i].val = nodes[nodes.Count - 1 - i].val;
                    nodes[nodes.Count - 1 - i].val = temp;
                }

                level++;
            }

            return root;
        }
    }
}
