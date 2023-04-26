using System;
using System.Collections.Generic;

namespace LeetCodeTasks._378KthSmallestElementinaSortedMatrix
{
    public class KthSmallestElementinaSortedMatrix
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            //return Heap(matrix, k);
            return BinarySearch(matrix, k);
        }

        public int Heap(int[][] matrix, int k)
        {
            var queue = new PriorityQueue<(int r, int c, int val), int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                queue.Enqueue((i, 0, matrix[i][0]), matrix[i][0]);
            }

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                k--;
                if (k == 0) return item.val;

                item.c++;
                if (item.c < matrix.Length)
                {
                    item.val = matrix[item.r][item.c];
                    queue.Enqueue(item, item.val);
                }
            }

            return 0;
        }

        public int BinarySearch(int[][] matrix, int k)
        {
            int n = matrix.Length;
            int high = matrix[n - 1][n - 1];
            int low = matrix[0][0];
            while (low <= high)
            {
                int count = 0;
                int max = low;
                int mid = low + (high - low) / 2;
                for (int r = 0, c = n - 1; r < n; r++)
                {
                    while (c >= 0 && mid < matrix[r][c]) c--;
                    if (c >= 0)
                    {
                        count += (c + 1);
                        max = Math.Max(max, matrix[r][c]);
                    }
                }

                if (count == k) return max;
                else if (count < k) low = mid + 1;
                else high = mid - 1;
            }

            return low; //if there are duplicates
        }
    }
}
