namespace LeetCodeTasks.Utility
{
    public static class TreeUtility
    {
        public static TreeNode BuildBinaryTree(int?[] arr)
        {
            var tree = new TreeNode[arr.Length];
            if (arr.Length == 0 || arr[0] == null) return null;

            tree[0] = new TreeNode(arr[0].Value);
            var j = 1;
            for (var i = 0; i < tree.Length; i++)
            {
                if (tree[i] == null) continue;

                TreeNode left = null;
                if (j < arr.Length && arr[j] != null)
                {
                    left = new TreeNode(arr[j].Value);
                    tree[j] = left;
                }
                j++;
                tree[i].left = left;

                TreeNode right = null;
                if (j < arr.Length && arr[j] != null)
                {
                    right = new TreeNode(arr[j].Value);
                    tree[j] = right;
                }
                j++;

                tree[i].right = right;
            }

            return tree[0];
        }
    }
}
