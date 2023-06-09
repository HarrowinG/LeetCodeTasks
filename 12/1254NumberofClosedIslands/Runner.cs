﻿using LeetCodeTasks.Utility;

namespace LeetCodeTasks._1254NumberofClosedIslands
{
    public class Runner
    {
        public void Run()
        {
            var cl = new NumberofClosedIslands();
            //var strGrid = "[[1,1,1,1,1,1,1,0],[1,0,0,0,0,1,1,0],[1,0,1,0,1,1,1,0],[1,0,0,0,0,1,0,1],[1,1,1,1,1,1,1,0]]";//2
            //var strGrid = "[[0,0,1,0,0],[0,1,0,1,0],[0,1,1,1,0]]";//1
            //var strGrid = "[[1,1,1,1,1,1,1],[1,0,0,0,0,0,1],[1,0,1,1,1,0,1],[1,0,1,0,1,0,1],[1,0,1,1,1,0,1],[1,0,0,0,0,0,1],[1,1,1,1,1,1,1]]";//2
            var strGrid = "[[0,1,0,1,0,0,0,1,1,0,1,1,0,0,1,1,1,0,1,1],[0,1,1,0,0,0,0,1,1,1,0,1,0,1,1,0,0,1,0,1],[1,1,0,1,0,0,1,1,1,0,0,0,1,0,0,1,0,1,0,0],[0,1,1,1,0,0,0,0,0,0,1,1,1,0,0,0,1,1,1,0],[1,1,0,0,1,0,0,1,1,0,1,1,0,1,1,1,0,0,1,1],[1,1,0,0,0,0,0,1,0,1,1,1,0,1,0,0,0,0,0,1],[1,0,1,1,0,1,0,1,0,0,1,0,1,1,1,1,1,0,1,0],[1,0,0,1,1,0,0,1,0,1,0,0,0,0,0,0,0,0,0,1],[0,0,0,1,1,1,0,1,1,1,0,1,0,1,1,0,1,0,0,0],[1,1,0,0,0,0,1,1,0,0,0,1,0,0,1,0,1,0,1,1],[1,0,0,1,1,1,1,0,1,0,1,1,1,0,0,0,0,1,1,0],[1,1,0,0,0,0,0,0,1,1,1,1,0,1,0,1,0,1,1,1],[0,1,1,0,0,1,1,0,0,1,0,1,1,1,1,1,1,0,0,0],[1,0,0,0,1,1,0,1,1,1,0,0,1,0,1,1,0,1,0,1]]";//6
            var grid = InputUtility.StringToIntArray2D(strGrid);
            var result = cl.ClosedIsland(grid);
            Console.WriteLine(result);
        }
    }
}
