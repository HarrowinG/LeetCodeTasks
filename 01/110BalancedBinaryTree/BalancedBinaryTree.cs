using LeetCodeTasks.Utility;

namespace LeetCodeTasks._110BalancedBinaryTree
{
    public class BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            return Dfs(root).IsBalanced;
        }

        private (int Depth, bool IsBalanced) Dfs(TreeNode root)
        {
            if (root == null) return (0, true);

            var left = Dfs(root.left);
            if (!left.IsBalanced) return (0, false);
            var right = Dfs(root.right);
            if (!right.IsBalanced) return (0, false);

            return (Math.Max(left.Depth, right.Depth) + 1, Math.Abs(left.Depth - right.Depth) <= 1);
        }
    }
}
