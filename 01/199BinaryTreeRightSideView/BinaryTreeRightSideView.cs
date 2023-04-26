using LeetCodeTasks.Utility;

namespace LeetCodeTasks._199BinaryTreeRightSideView
{
    public class BinaryTreeRightSideView
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var n = queue.Count;
                var right = 0;
                for (int i = 0; i < n; i++)
                {
                    var node = queue.Dequeue();
                    right = node.val;

                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }

                result.Add(right);
            }

            return result;
        }
    }
}
