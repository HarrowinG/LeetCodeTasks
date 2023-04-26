﻿namespace LeetCodeTasks._211DesignAddandSearchWordsDataStructure
{
    public class Runner
    {
        public void Run()
        {
            WordDictionary wordDictionary = new WordDictionary();
            wordDictionary.AddWord("bad");
            wordDictionary.AddWord("dad");
            wordDictionary.AddWord("mad");
            wordDictionary.AddWord("armagedon");
            Console.WriteLine(wordDictionary.Search("pad")); // return False
            Console.WriteLine(wordDictionary.Search("bad")); // return True
            Console.WriteLine(wordDictionary.Search(".ad")); // return True
            Console.WriteLine(wordDictionary.Search("b..")); // return True
            Console.WriteLine(wordDictionary.Search(".r.a.e.on")); // return True
            Console.WriteLine(wordDictionary.Search("........b")); // return False
        }
    }
}
