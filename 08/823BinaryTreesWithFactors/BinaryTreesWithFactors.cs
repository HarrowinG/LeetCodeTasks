namespace LeetCodeTasks._823BinaryTreesWithFactors
{
    public class BinaryTreesWithFactors
    {
        public int NumFactoredBinaryTrees(int[] arr)
        {
            Array.Sort(arr);
            var modulo = 1000000007;
            var dict = new Dictionary<int, long>();
            foreach (var item in arr)
            {
                dict[item] = 1;
            }

            long count = 0;
            foreach (var root in dict.Keys)
            {
                foreach (var leaf in dict.Keys)
                {
                    if (leaf * leaf > root) break;
                    if (root % leaf != 0) continue;
                    var reminder = root / leaf;
                    var multiplier = reminder == leaf ? 1 : 2;
                    if (!dict.ContainsKey(reminder)) continue;

                    dict[root] = (dict[root] + dict[leaf] * dict[reminder] * multiplier) % modulo;
                }

                count = (count + dict[root]) % modulo;
            }

            return (int)count;
        }
    }
}
