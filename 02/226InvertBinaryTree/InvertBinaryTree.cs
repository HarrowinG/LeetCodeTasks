using LeetCodeTasks.Utility;

namespace LeetCodeTasks._226InvertBinaryTree
{
    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            //Dfs(root);
            Bfs(root);
            return root;
        }

        private void Dfs(TreeNode root)
        {
            if (root == null) return;
            var temp = root.left;
            root.left = root.right;
            root.right = temp;
            Dfs(root.left);
            Dfs(root.right);
        }

        private void Bfs(TreeNode root)
        {
            if (root == null) return;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                var temp = node.left;
                node.left = node.right;
                node.right = temp;

                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
        }
    }
}
