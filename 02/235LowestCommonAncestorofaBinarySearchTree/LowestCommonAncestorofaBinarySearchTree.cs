using LeetCodeTasks.Utility;

namespace LeetCodeTasks._235LowestCommonAncestorofaBinarySearchTree
{
    public class LowestCommonAncestorofaBinarySearchTree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return null;

            if (p.val < root.val && q.val < root.val)
            {
                return LowestCommonAncestor(root.left, p, q);
            }
            else if (p.val > root.val && q.val > root.val)
            {
                return LowestCommonAncestor(root.right, p, q);
            }

            return root;
        }
    }
}
