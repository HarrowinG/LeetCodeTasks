using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1448CountGoodNodesinBinaryTree
{
    public class CountGoodNodesinBinaryTree
    {
        public int GoodNodes(TreeNode root)
        {
            return Dfs(root, root.val);
        }

        private int Dfs(TreeNode root, int max)
        {
            if (root == null) return 0;

            var count = root.val >= max ? 1 : 0;
            max = Math.Max(max, root.val);
            count += Dfs(root.left, max);
            count += Dfs(root.right, max);
            return count;
        }
    }
}
