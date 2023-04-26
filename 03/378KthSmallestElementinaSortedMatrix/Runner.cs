using System;

namespace LeetCodeTasks._378KthSmallestElementinaSortedMatrix
{
    public class Runner
    {
        public void Run()
        {
            var matrix = new int[3][];
            matrix[0] = new int[] { 1, 5, 9 };
            matrix[1] = new int[] { 10, 11, 13 };
            matrix[2] = new int[] { 12, 13, 15 };
            var k = 8;//13
            var cl = new KthSmallestElementinaSortedMatrix();
            var result = cl.KthSmallest(matrix, k);
            Console.WriteLine(result);
        }
    }
}
