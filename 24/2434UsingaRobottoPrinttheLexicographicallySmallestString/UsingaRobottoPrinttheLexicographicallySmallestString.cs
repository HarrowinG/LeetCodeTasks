using System.Text;

namespace LeetCodeTasks._2434UsingaRobottoPrinttheLexicographicallySmallestString
{
    public class UsingaRobottoPrinttheLexicographicallySmallestString
    {
        public string RobotWithString(string s)
        {
            return Stack(s);
        }

        private string Stack(string s)
        {
            var p = new StringBuilder(s.Length);
            var t = new Stack<char>();
            var count = new int[26];
            var lower = 0;
            foreach (var c in s)
                count[c - 'a']++;

            foreach (var c in s)
            {
                t.Push(c);
                count[c - 'a']--;
                while (lower < 25 && count[lower] == 0)
                    lower++;
                while (t.Count > 0 && t.Peek() - 'a' <= lower)
                {
                    p.Append(t.Pop());
                }
            }

            return p.ToString();
        }
    }
}
