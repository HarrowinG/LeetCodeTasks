namespace LeetCodeTasks.Utility
{
    public static class ResultUtility
    {
        public static string Array<T>(T[] values)
        {
            var str = "[";
            foreach (var value in values)
            {
                str += $"{value},";
            }
            str = str.TrimEnd(',');
            str += "]";
            return str;
        }

        public static string Array2D<T>(T[][] values)
        {
            var str = "[";
            foreach (var value in values)
            {
                str += $"{Array(value)},";
            }
            str = str.TrimEnd(',');
            str += "]";
            return str;
        }

        public static string List<T>(IList<T> values)
        {
            var str = "[";
            foreach (var value in values)
            {
                str += $"{value},";
            }
            str = str.TrimEnd(',');
            str += "]";
            return str;
        }

        public static string List2D<T>(IList<IList<T>> values)
        {
            var str = "[";
            foreach (var value in values)
            {
                str += $"{List(value)},";
            }
            str = str.TrimEnd(',');
            str += "]";
            return str;
        }

        public static string LinkedList(ListNode node)
        {
            var str = "[";
            while (node != null)
            {
                str += $"{node.val},";
                node = node.next;
            }
            str = str.TrimEnd(',');
            str += "]";
            return str;
        }

        public static string BinaryTree(TreeNode root)
        {
            var str = "[";
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var depth = GetDepth(root);
            while (queue.Count > 0)
            {
                depth--;
                var n = queue.Count;
                for (var i = 0; i < n; i++)
                {
                    var node = queue.Dequeue();
                    if (node != null)
                    {
                        str += $"{node.val},";
                    }
                    else
                    {
                        str += $"null,";
                    }

                    if (node != null && depth > 0)
                    {
                        queue.Enqueue(node.left);
                        queue.Enqueue(node.right);
                    }
                }
            }

            str = str.TrimEnd(',');
            str += "]";
            return str;

            int GetDepth(TreeNode root)
            {
                if (root == null) return 0;

                return Math.Max(GetDepth(root.left), GetDepth(root.right)) + 1;
            }
        }
    }
}
