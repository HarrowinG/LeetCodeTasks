using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly103
{
    public class MakeArrayEmpty
    {
        //wrong
        public long CountOperationsToEmptyArray(int[] nums)
        {
            long operations = 0;
            var removed = 0;
            var heap = new PriorityQueue<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                heap.Enqueue(i, num);
            }

            while (heap.Count > 0)
            {
                var pos = heap.Dequeue();
                if (removed < pos)
                    operations += pos - removed;

                operations++;
                removed++;
            }

            return operations;
        }

        //tle
        public long CountOperationsToEmptyArray2(int[] nums)
        {
            long operations = 0;
            var head = new DoubleLinkedListNode();
            var node = new DoubleLinkedListNode { Val = nums[0] };
            head.Next = node;
            var heap = new PriorityQueue<int, int>();
            heap.Enqueue(nums[0], nums[0]);
            for (var i = 1; i < nums.Length; i++)
            {
                var num = nums[i];
                heap.Enqueue(num, num);
                var temp = new DoubleLinkedListNode { Val = num };
                temp.Prev = node;
                node.Next = temp;
                node = node.Next;
            }

            node.Next = head.Next;
            head.Next.Prev = node;
            node = head.Next;

            while (heap.Count > 1)
            {
                var min = heap.Dequeue();
                while (node.Val != min)
                {
                    node = node.Next;
                    operations++;
                }

                node.Next.Prev = node.Prev;
                node.Prev.Next = node.Next;
                node = node.Next;
                operations++;
            }

            return operations + 1;
        }

        private class DoubleLinkedListNode
        {
            public DoubleLinkedListNode Next { get; set; }
            public DoubleLinkedListNode Prev { get; set; }
            public int Val { get; set; }
        }

        //tle
        public long CountOperationsToEmptyArray1(int[] nums)
        {
            long operations = 0;
            var queue = new Queue<int>();
            var heap = new PriorityQueue<int, int>();
            foreach (int num in nums)
            {
                queue.Enqueue(num);
                heap.Enqueue(num, num);
            }

            while (heap.Count > 0)
            {
                var min = heap.Dequeue();
                while (queue.Peek() != min)
                {
                    queue.Enqueue(queue.Dequeue());
                    operations++;
                }

                queue.Dequeue();
                operations++;
            }

            return operations;
        }
    }
}
