using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly100
{
    public class FindScoreofanArrayAfterMarkingAllElements
    {
        private class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public long FindScore(int[] nums) //todo
        {
            long result = 0;
            var root = BuildTree(0, nums.Length - 1, nums);
            while (root != null)
            {
                result += root.val;
                Mark(ref root);
            }


            return result;
        }

        private (bool removeLeft, bool removeRight) Mark(ref TreeNode node)
        {
            if (node.left != null && node.left.val == node.val)
            {
                var res = Mark(ref node.left);
            }
            else if (node.right != null &&  node.right.val == node.val)
            {
                Mark(ref node.right);
            }

            node = null;
            return (true, true);
        }

        private TreeNode BuildTree(int l, int r, int[] nums)
        {
            if (r < l) return null;
            if (l == r) return new TreeNode(nums[l]);

            var middle = l + (r - l) / 2;
            var node = new TreeNode();
            var left = BuildTree(l, middle, nums);
            node.left = left;
            var right = BuildTree(middle + 1, r, nums);
            node.right = right;

            var min = int.MaxValue;
            if (left != null) min = Math.Min(min, left.val);
            if (right != null) min = Math.Min(min, right.val);
            node.val = min;
            return node;
        }
    }
}
