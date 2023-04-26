using System.Collections.Generic;

namespace LeetCodeTasks.RansomNoteFolder
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var ransomLength = ransomNote.Length;
            var magazineLength = magazine.Length;
            if (ransomLength > magazineLength)
            {
                return false;
            }

            var dict = new Dictionary<char, int>();
            foreach (var rn in ransomNote)
            {
                if (dict.ContainsKey(rn))
                {
                    dict[rn]++;
                }
                else
                {
                    dict[rn] = 1;
                }
            }

            for (var i = 0; i < magazineLength; i++)
            {
                if (ransomLength > magazineLength - i)
                {
                    return false;
                }

                var m = magazine[i];
                if (dict.ContainsKey(m))
                {
                    dict[m]--;
                    ransomLength--;
                    if (ransomLength <= 0)
                    {
                        return true;
                    }
                    if (dict[m] <= 0)
                    {
                        dict.Remove(m);
                    }
                }
            }

            return ransomLength <= 0;
        }
    }
}
