namespace LeetCodeTasks._763PartitionLabels
{
    public class PartitionLabelsClass
    {
        public IList<int> PartitionLabels(string s)
        {
            var result = new List<int>();
            var lastPositions = new int[26];
            for (var i = 0; i < s.Length; i++)
                lastPositions[s[i] - 'a'] = i;

            var l = 0;
            var r = 0;
            while (r < s.Length)
            {
                for (var i = l; i <= r; i++)
                    r = Math.Max(r, lastPositions[s[i] - 'a']);

                result.Add(r - l + 1);
                r++;
                l = r;
            }

            return result;
        }
    }
}
