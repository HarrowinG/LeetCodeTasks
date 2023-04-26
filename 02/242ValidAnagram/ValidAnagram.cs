using System.Collections.Immutable;

namespace LeetCodeTasks._242ValidAnagram
{
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            //return Dict(s, t);
            return Sort(s, t);
        }

        private bool Dict(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                dict[s[i]] = dict.GetValueOrDefault(s[i], 0) + 1;
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (!dict.ContainsKey(t[i])) return false;

                dict[t[i]]--;
                if (dict[t[i]] <= 0) dict.Remove(t[i]);
            }

            return dict.Count == 0;
        }

        private bool Sort(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var sArr = s.ToCharArray();
            Array.Sort(sArr);
            s = new string(sArr);
            var tArr = t.ToCharArray();
            Array.Sort(tArr);
            t = new string(tArr);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != t[i]) return false;
            }

            return true;
        }
    }
}
