using LeetCodeTasks.Utility;

namespace LeetCodeTasks._572SubtreeofAnotherTree
{
    public class SubtreeofAnotherTree
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            return Bfs(root, subRoot);
        }

        private bool Bfs(TreeNode root, TreeNode subRoot)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var wasMatch = false;
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node.val == subRoot.val)
                {
                    wasMatch = Dfs(node, subRoot);
                    if (wasMatch) return true;
                }

                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }

            return false;
        }

        private bool Dfs(TreeNode root, TreeNode subRoot)
        {
            if (root == subRoot) return true;
            if (root != null && subRoot != null)
            {
                return root.val == subRoot.val && Dfs(root.left, subRoot.left) && Dfs(root.right, subRoot.right);
            }

            return false;
        }
    }
}
