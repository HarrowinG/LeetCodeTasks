using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1372LongestZigZagPathinaBinaryTree
{
    public class LongestZigZagPathinaBinaryTree
    {
        public int LongestZigZag(TreeNode root)
        {
            return Dfs(root)[2];
        }

        private int[] Dfs(TreeNode root)
        {
            if (root == null) return new int[] { -1, -1, -1 };

            var left = Dfs(root.left);
            var right = Dfs(root.right);
            var res = Math.Max(Math.Max(left[1], right[0]) + 1, Math.Max(left[2], right[2]));
            return new int[] { left[1] + 1, right[0] + 1, res };
        }
    }
}
