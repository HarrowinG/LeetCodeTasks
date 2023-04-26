namespace LeetCodeTasks._1639NumberofWaystoFormaTargetStringGivenaDictionary
{
    public class NumberofWaystoFormaTargetStringGivenaDictionary
    {
        public int NumWays(string[] words, string target)
        {
            long modulo = (long)1e9 + 7;
            var res = new long[target.Length + 1];
            res[0] = 1;
            for (int i = 0; i < words[0].Length; i++)
            {
                int[] count = new int[26];
                foreach (var word in words)
                    count[word[i] - 'a']++;
                for (int j = target.Length - 1; j >= 0; j--)
                {
                    res[j + 1] += res[j] * count[target[j] - 'a'] % modulo;
                }
            }
            return (int)(res[target.Length] % modulo);
        }
    }
}
