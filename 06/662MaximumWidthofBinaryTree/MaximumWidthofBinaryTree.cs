using LeetCodeTasks.Utility;

namespace LeetCodeTasks._662MaximumWidthofBinaryTree
{
    public class MaximumWidthofBinaryTree
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            var max = 1;
            var queue = new Queue<(TreeNode node, int index)>();
            queue.Enqueue((root, 0));
            while (queue.Count > 0)
            {
                var start = queue.Peek().index;
                
                var n = queue.Count;
                for (var i = 0; i < n; i++)
                {
                    var (node, index) = queue.Dequeue();
                    if (i == n - 1)
                        max = Math.Max(max, index - start + 1);

                    if (node.left != null)
                        queue.Enqueue((node.left, (index - start) * 2 + 1));
                    if (node.right != null)
                        queue.Enqueue((node.right, (index - start) * 2 + 2));
                }
            }

            return max;
        }
    }
}
