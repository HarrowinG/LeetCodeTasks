using LeetCodeTasks.Utility;

namespace LeetCodeTasks._102BinaryTreeLevelOrderTraversal
{
    public class BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null) return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var n = queue.Count;
                var level = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    var node = queue.Dequeue();
                    level.Add(node.val);

                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }

                result.Add(level);
            }

            return result;
        }
    }
}
