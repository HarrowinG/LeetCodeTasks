using System;

namespace LeetCodeTasks.RansomNoteFolder
{
    public class Runner
    {
        public void Run()
        {
            var ransomNote = new RansomNote();
            var result = ransomNote.CanConstruct("aaccddee", "abcabcddee");
            Console.WriteLine(result);
        }
    }
}
