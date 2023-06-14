using LeetCodeTasks.Utility;

namespace LeetCodeTasks._530MinimumAbsoluteDifferenceinBST
{
    public class MinimumAbsoluteDifferenceinBST
    {
        int _min = int.MaxValue;
        int _prev = -1;

        public int GetMinimumDifference(TreeNode root)
        {
            if (root == null) return _min;

            GetMinimumDifference(root.left);

            if (_prev >= 0)
            {
                _min = Math.Min(_min, root.val - _prev);
            }
            _prev = root.val;

            GetMinimumDifference(root.right);

            return _min;
        }
    }
}
