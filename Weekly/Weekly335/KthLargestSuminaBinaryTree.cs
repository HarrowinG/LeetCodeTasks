using LeetCodeTasks.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly335
{
    public class KthLargestSuminaBinaryTree
    {
        public long KthLargestLevelSum(TreeNode root, int k)
        {
            var sums = new PriorityQueue<long, long>(Comparer<long>.Create((a, b) => b.CompareTo(a)));
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var n = queue.Count;
                long sum = 0;
                for (var i = 0; i < n; i++)
                {
                    var item = queue.Dequeue();
                    sum += item.val;
                    if (item.left != null) queue.Enqueue(item.left);
                    if (item.right != null) queue.Enqueue(item.right);
                }

                sums.Enqueue(sum, sum);
            }

            if (k > sums.Count) return -1;
            while (k > 1 && sums.Count > 1)
            {
                sums.Dequeue();
                k--;
            }

            return sums.Dequeue();
        }
    }
}
