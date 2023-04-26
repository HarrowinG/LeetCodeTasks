using LeetCodeTasks.Utility;

namespace LeetCodeTasks._543DiameterofBinaryTree
{
    public class DiameterofBinaryTree
    {
        private int _diametr;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            Dfs(root);
            return _diametr;
        }

        private int Dfs(TreeNode root)
        {
            if (root == null) return 0;

            var left = Dfs(root.left);
            var right = Dfs(root.right);

            var depth = Math.Max(left, right);
            _diametr = Math.Max(_diametr, left + right);
            return depth + 1;
        }
    }
}
