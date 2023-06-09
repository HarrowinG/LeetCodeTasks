﻿namespace LeetCodeTasks._705DesignHashSet
{
    public class Runner
    {
        public void Run()
        {
            MyHashSet myHashSet = new MyHashSet();
            myHashSet.Add(1);      // set = [1]
            myHashSet.Add(2);      // set = [1, 2]
            Console.WriteLine(myHashSet.Contains(1)); // return True
            Console.WriteLine(myHashSet.Contains(3)); // return False, (not found)
            myHashSet.Add(2);      // set = [1, 2]
            Console.WriteLine(myHashSet.Contains(2)); // return True
            myHashSet.Remove(2);   // set = [1]
            Console.WriteLine(myHashSet.Contains(2)); // return False, (already removed)
        }
    }
}
