using LeetCodeTasks.Utility;

namespace LeetCodeTasks._98ValidateBinarySearchTree
{
    public class ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            return Dfs(root, long.MinValue, long.MaxValue);
        }

        private bool Dfs(TreeNode root, long min, long max)
        {
            if (root == null) return true;
            if (root.val > min && root.val < max)
            {
                return Dfs(root.left, min, root.val)
                    && Dfs(root.right, root.val, max);
            }

            return false;
        }
    }
}
