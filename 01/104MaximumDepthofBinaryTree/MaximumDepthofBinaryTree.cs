using LeetCodeTasks.Utility;

namespace LeetCodeTasks._104MaximumDepthofBinaryTree
{
    public class MaximumDepthofBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            return Dfs(root);
        }

        private int Dfs(TreeNode root)
        {
            if (root == null) return 0;

            var res = Math.Max(Dfs(root.left), Dfs(root.right));
            return res + 1;
        }
    }
}
