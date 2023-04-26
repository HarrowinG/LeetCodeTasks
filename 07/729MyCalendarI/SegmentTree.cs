using System;

namespace LeetCodeTasks._729MyCalendarI
{
    public class SegmentTreeNode
    {
        public int Start { get; set; }
        public int End { get; set; }
        public bool Booked { get; set; }
        public SegmentTreeNode Left { get; set; }
        public SegmentTreeNode Right { get; set; }

        public SegmentTreeNode(int start, int end, bool book)
        {
            Start = start;
            End = end;
            Booked = book;
            Left = Right = null;
        }
    }

    public class SegmentTree
    {
        private SegmentTreeNode _root;

        public SegmentTree(int start, int end)
        {
            _root = new SegmentTreeNode(start, end, false);
        }

        public bool Update(int start, int end, bool book)
        {
            return Update(_root, start, end, book);
        }

        private bool Update(SegmentTreeNode node, int start, int end, bool book)
        {
            if (node.Start == start && node.End == end)
            {
                node.Booked = book;
                return node.Booked;
            }

            if (start >= node.End || end <= node.Start) return false;

            int mid = node.Start + (node.End - node.Start) / 2;

            if (node.Left == null)
            {
                node.Left = new SegmentTreeNode(node.Start, mid, node.Booked);
                node.Right = new SegmentTreeNode(mid, node.End, node.Booked);
            }

            bool leftBooked = Update(node.Left, start, Math.Min(mid, end), book);
            bool rightBooked = Update(node.Right, Math.Max(mid, start), end, book);

            node.Booked = leftBooked || rightBooked;

            return node.Booked;
        }

        public bool Query(int start, int end)
        {
            return Query(_root, start, end);
        }

        private bool Query(SegmentTreeNode node, int start, int end)
        {
            if (node.Start == start && node.End == end)
            {
                return !node.Booked;
            }

            if (node.Left == null || node.Right == null) return !node.Booked;

            int mid = node.Start + (node.End - node.Start) / 2;

            if (end <= mid)
            {
                return Query(node.Left, start, end);
            }

            if (start >= mid)
            {
                return Query(node.Right, start, end);
            }

            return Query(node.Left, start, mid) &&
                    Query(node.Right, mid, end);
        }
    }
}
