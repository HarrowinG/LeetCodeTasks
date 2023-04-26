namespace LeetCodeTasks._14LongestCommonPrefix
{
    public class LongestCommonPrefixClass
    {
        public string LongestCommonPrefix(string[] strs)
        {
            return CompareBySymbol(strs);
            //return Sort(strs);

        }

        private string CompareBySymbol(string[] strs)
        {
            if (strs.Length == 1)
            {
                return strs[0];
            }

            var index = 0;
            while (index < strs[0].Length)
            {
                var currentSymbol = strs[0][index];
                var noMoreMatch = false;
                for (int i = 1; i < strs.Length; i++)
                {
                    if (strs[i].Length <= index
                        || strs[i][index] != currentSymbol)
                    {
                        noMoreMatch = true;
                        break;
                    }
                }

                if (noMoreMatch) break;

                index++;
            }

            return strs[0][..index];
        }

        private string Sort(string[] strs)
        {
            Array.Sort(strs);
            var first = strs[0];
            var last = strs[strs.Length - 1];

            var index = 0;
            while (index < first.Length)
            {
                if (first[index] == last[index]) index++;
                else break;
            }

            return strs[0][..index];
        }
    }
}
