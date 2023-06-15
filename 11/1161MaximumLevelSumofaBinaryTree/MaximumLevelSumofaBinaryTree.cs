using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1161MaximumLevelSumofaBinaryTree
{
    public class MaximumLevelSumofaBinaryTree
    {
        public int MaxLevelSum(TreeNode root)
        {
            var max = int.MinValue;
            var level = 0; var maxLevel = 1;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                level++;
                var sum = 0;
                var n = queue.Count;
                for (var i = 0; i < n; i++)
                {
                    var node = queue.Dequeue();
                    sum += node.val;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }

                if (sum > max)
                {
                    max = sum;
                    maxLevel = level;
                }
            }

            return maxLevel;
        }
    }
}
