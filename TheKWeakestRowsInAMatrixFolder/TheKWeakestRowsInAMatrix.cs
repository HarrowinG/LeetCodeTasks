using System.Collections.Generic;

namespace LeetCodeTasks.TheKWeakestRowsInAMatrixFolder
{
    public class TheKWeakestRowsInAMatrix
    {
        public class Node
        {
            public int Sum { get; set; }
            public int Index { get; set; }
            public Node Prev { get; set; }
            public Node Next { get; set; }
        }

        public int[] KWeakestRows(int[][] mat, int k)
        {
            var array = new int[k];
            var currentCount = 0;
            Node head = null;
            Node tail = null;

            for (var i = 0; i < mat.Length; i++)
            {
                var rowSum = 0;
                for (var j = 0; j < mat[i].Length; j++)
                {
                    rowSum += mat[i][j];
                }

                if (currentCount < k
                    || tail.Sum > rowSum
                    || tail.Sum == rowSum && tail.Index > i)
                {
                    (head, tail, currentCount) = AddToList(head, tail, currentCount, k, (rowSum, i));
                }
            }

            for (int i = 0; i < k; i++)
            {
                array[i] = head.Index;
                head = head.Next;
            }

            return array;
        }

        private (Node Head, Node Tail, int CurrentCount) AddToList(Node head, Node tail, int currentCount, int maxCount, (int Sum, int Index) item)
        {
            if (head == null)
            {
                return AddFirst(item);
            }

            var insertAfterNode = FindToInsert(head, item);

            return Insert(head, tail, insertAfterNode, currentCount, maxCount, item);
        }

        private (Node Head, Node Tail, int CurrentCount) AddFirst((int Sum, int Index) item)
        {
            var head = new Node
            {
                Sum = item.Sum,
                Index = item.Index,
                Next = null,
                Prev = null
            };
            var tail = head;
            return (head, tail, 1);
        }

        private Node FindToInsert(Node head, (int Sum, int Index) item)
        {
            if (head.Sum > item.Sum)
            {
                return null;
            }
            if (head.Sum == item.Sum && head.Index > item.Index)
            {
                return null;
            }

            while (true)
            {
                if (head.Sum < item.Sum)
                {
                    if (head.Next == null)
                    {
                        return head;
                    }
                    head = head.Next;
                }
                else if(head.Sum == item.Sum)
                {
                    break;
                }
                else
                {
                    return head.Prev;
                }
            }

            while (true)
            {
                if (head.Index < item.Index)
                {
                    if (head.Next == null)
                    {
                        return head;
                    }
                    if (head.Next.Sum == item.Sum)
                    {
                        head = head.Next;
                    }
                    else
                    {
                        return head;
                    }
                }
                else
                {
                    return head.Prev;
                }
            }
        }

        private (Node Head, Node Tail, int CurrentCount) Insert(Node head, Node tail, Node insertAfterNode, int currentCount, int maxCount, (int Sum, int Index) item)
        {
            if (insertAfterNode == null)
            {
                insertAfterNode = new Node
                {
                    Sum = item.Sum,
                    Index = item.Index,
                    Next = head,
                    Prev = null
                };
                head.Prev = insertAfterNode;
                head = insertAfterNode;
                currentCount++;
                if (currentCount > maxCount)
                {
                    tail = CutTail(tail);
                    currentCount--;
                }
            }
            else if (insertAfterNode.Next == null)
            {
                insertAfterNode.Next = new Node
                {
                    Sum = item.Sum,
                    Index = item.Index,
                    Next = null,
                    Prev = insertAfterNode
                };

                tail = insertAfterNode.Next;
                currentCount++;
                if (currentCount > maxCount)
                {
                    tail = CutTail(tail);
                    currentCount--;
                }
            }
            else
            {
                var next = insertAfterNode.Next;
                insertAfterNode.Next = new Node
                {
                    Sum = item.Sum,
                    Index = item.Index,
                    Next = next,
                    Prev = insertAfterNode
                };
                next.Prev = insertAfterNode.Next;
                currentCount++;
                if (currentCount > maxCount)
                {
                    tail = CutTail(tail);
                    currentCount--;
                }
            }

            return (head, tail, currentCount);
        }

        private Node CutTail(Node tail)
        {
            tail = tail.Prev;
            tail.Next = null;
            return tail;
        }
    }
}
