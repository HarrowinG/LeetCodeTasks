using LeetCodeTasks.Utility;

namespace LeetCodeTasks._108ConvertSortedArraytoBinarySearchTree
{
    public class ConvertSortedArraytoBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return Dfs(0, nums.Length - 1, nums);
        }

        private TreeNode Dfs(int left, int right, int[] nums)
        {
            if (left > right) return null;

            var mid = left + (right - left) / 2;
            var leftNode = Dfs(left, mid - 1, nums);
            var rightNode = Dfs(mid + 1, right, nums);
            return new TreeNode(nums[mid], leftNode, rightNode);
        }
    }
}
