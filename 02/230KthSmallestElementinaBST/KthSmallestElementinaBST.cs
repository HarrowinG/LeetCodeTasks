using LeetCodeTasks.Utility;

namespace LeetCodeTasks._230KthSmallestElementinaBST
{
    public class KthSmallestElementinaBST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            //return Dfs(root, k).val;
            return Iterative(root, k);
        }

        private int Iterative(TreeNode root, int k)
        {
            var stack = new Stack<TreeNode>();
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            while (k != 0)
            {
                var node = stack.Pop();
                k--;
                if (k == 0) return node.val;

                var right = node.right;
                while (right != null)
                {
                    stack.Push(right);
                    right = right.left;
                }
            }

            return -1;
        }

        private (bool Found, int val) Dfs(TreeNode root, int k)
        {
            if (root == null) return (false, 0);

            var left = Dfs(root.left, k);
            if (left.Found) return left;

            var pos = left.val + 1;
            if (pos == k) return (true, root.val);

            var right = Dfs(root.right, k - pos);
            if (right.Found) return right;

            return (false, pos + right.val);
        }
    }
}
