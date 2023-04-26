using LeetCodeTasks.Utility;

namespace LeetCodeTasks._100SameTree
{
    public class SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            return Dfs(p, q);
        }

        private bool Dfs(TreeNode p, TreeNode q)
        {
            if (p == q) return true;
            if (p != null && q != null)
            {
                return p.val == q.val && Dfs(p.left, q.left) && Dfs(p.right, q.right);
            }

            return false;
        }
    }
}
