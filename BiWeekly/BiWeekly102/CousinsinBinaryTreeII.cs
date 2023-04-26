using LeetCodeTasks.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly102
{
    public class CousinsinBinaryTreeII
    {
        public TreeNode ReplaceValueInTree(TreeNode root)
        {
            var dict = new Dictionary<TreeNode, int>();
            dict[root] = 0;
            var queue = new Queue<(TreeNode Node, TreeNode Parent, int Val)>();
            queue.Enqueue((root, root, root.val));
            while (queue.Count > 0)
            {
                var n = queue.Count();
                var list = new List<(TreeNode Node, TreeNode Parent, int Val)>();
                for (var i = 0; i < n; i++)
                {
                    list.Add(queue.Dequeue());
                }

                for (var i = 0; i < n; i++)
                {
                    if (list[i].Node.left != null)
                        queue.Enqueue((list[i].Node.left, list[i].Node, list[i].Node.left.val));
                    if (list[i].Node.right != null)
                        queue.Enqueue((list[i].Node.right, list[i].Node, list[i].Node.right.val));

                    if (dict.ContainsKey(list[i].Parent))
                    {
                        list[i].Node.val = dict[list[i].Parent];
                        continue;
                    }

                    var sum = 0;
                    for (var j = 0; j < n; j++)
                    {
                        if (i == j) continue;
                        if (list[i].Parent == list[j].Parent) continue;

                        sum += list[j].Val;
                    }

                    list[i].Node.val = sum;
                    dict[list[i].Parent] = sum;
                }
            }

            return root;
        }
    }
}
