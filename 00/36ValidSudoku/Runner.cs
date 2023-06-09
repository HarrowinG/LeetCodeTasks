﻿namespace LeetCodeTasks._36ValidSudoku
{
    public class Runner
    {
        public void Run()
        {
            /*
            var board = new char[][]
            {
                new[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'}
                ,new[]{'6', '.', '.', '1', '9', '5', '.', '.', '.'}
                ,new[]{'.', '9', '8', '.', '.', '.', '.', '6', '.'}
                ,new[]{'8', '.', '.', '.', '6', '.', '.', '.', '3'}
                ,new[]{'4', '.', '.', '8', '.', '3', '.', '.', '1'}
                ,new[]{'7', '.', '.', '.', '2', '.', '.', '.', '6'}
                ,new[]{'.', '6', '.', '.', '.', '.', '2', '8', '.'}
                ,new[]{'.', '.', '.', '4', '1', '9', '.', '.', '5'}
                ,new[]{'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };//true
            */
            
            var board = new char[][]
            {
                new[] {'8', '3', '.', '.', '7', '.', '.', '.', '.'}
                ,new[]{'6', '.', '.', '1', '9', '5', '.', '.', '.'}
                ,new[]{'.', '9', '8', '.', '.', '.', '.', '6', '.'}
                ,new[]{'8', '.', '.', '.', '6', '.', '.', '.', '3'}
                ,new[]{'4', '.', '.', '8', '.', '3', '.', '.', '1'}
                ,new[]{'7', '.', '.', '.', '2', '.', '.', '.', '6'}
                ,new[]{'.', '6', '.', '.', '.', '.', '2', '8', '.'}
                ,new[]{'.', '.', '.', '4', '1', '9', '.', '.', '5'}
                ,new[]{'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };//false
            
            var cl = new ValidSudoku();
            var result = cl.IsValidSudoku(board);
            Console.WriteLine(result);
        }
    }
}
