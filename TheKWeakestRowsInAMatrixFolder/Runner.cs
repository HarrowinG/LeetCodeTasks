using System;

namespace LeetCodeTasks.TheKWeakestRowsInAMatrixFolder
{
    public class Runner
    {
        public void Run()
        {
            var theKWeakestRowsInAMatrix = new TheKWeakestRowsInAMatrix();
            /*
            var mat = new []
            {
                new[] {1, 1, 0, 0, 0},
                new[] {1, 1, 1, 1, 0},
                new[] {1, 0, 0, 0, 0},
                new[] {1, 1, 0, 0, 0},
                new[] {1, 1, 1, 1, 1}
            };
            var k = 3;
            var result = theKWeakestRowsInAMatrix.KWeakestRows(mat, k);
            */
            var mat = new[]
            { 
                new [] {1, 0, 0, 0},
                new [] {1, 1, 1, 1},
                new [] {1, 0, 0, 0},
                new [] {1, 0, 0, 0}
            };
            var k = 2;
            var result = theKWeakestRowsInAMatrix.KWeakestRows(mat, k);

            Console.Write("[");
            for (int i = 0; i < result.Length - 1; i++)
            {
                Console.Write($"{result[i]},");
            }
            Console.Write($"{result[result.Length-1]}]");
            Console.WriteLine();
        }
    }
}
