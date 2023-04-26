using System.Linq;

namespace LeetCodeTasks.RegularExpressionMatchingFolder
{
    public class RegularExpressionMatching
    {
        public bool IsMatch(string s, string p)
        {
            CleanPattern(ref p);
            if (string.IsNullOrEmpty(p))
            {
                return string.IsNullOrEmpty(s);
            }
            
            bool firstMatch = !string.IsNullOrEmpty(s) 
                              && (p[0] == '.' || p[0] == s[0]);

            if (p.Length >= 2 && p[1] == '*')
            {
                return IsMatch(s, p.Substring(2)) 
                       || firstMatch 
                          && IsMatch(s.Substring(1), p);
            }

            return firstMatch && IsMatch(s.Substring(1), p.Substring(1));
        }

        private void CleanPattern(ref string p)
        {
            var list = p.ToList();
            var i = 0;
            while (i < list.Count)
            {
                if (list[i] == '*')
                {
                    if (list[i - 1] == '.')
                    {
                        while (i - 2 >= 0 && list[i - 2] == '*')
                        {
                            list.RemoveRange(i - 3, 2);
                            i -= 2;
                        }
                        while (i + 2 < list.Count && list[i + 2] == '*')
                        {
                            list.RemoveRange(i + 1, 2);
                        }
                    }

                    if (i + 2 < list.Count && list[i + 2] == '*')
                    {
                        if (list[i - 1] == list[i + 1])
                        {
                            list.RemoveRange(i + 1, 2);
                            continue;
                        }
                    }
                }

                i++;
            }

            p = new string(list.ToArray());
        }
    }
}
