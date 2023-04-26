using System.Text;

namespace LeetCodeTasks._1768MergeStringsAlternately
{
    public class MergeStringsAlternately
    {
        public string MergeAlternately(string word1, string word2)
        {
            var sb = new StringBuilder(word1.Length + word2.Length);
            var i = 0; var j = 0;
            while (i < word1.Length && j < word2.Length)
            {
                sb.Append(word1[i]);
                sb.Append(word2[j]);
                i++;
                j++;
            }

            for (; i < word1.Length; i++)
                sb.Append(word1[i]);
            for (; j < word2.Length; j++)
                sb.Append(word2[j]);

            return sb.ToString();
        }
    }
}
