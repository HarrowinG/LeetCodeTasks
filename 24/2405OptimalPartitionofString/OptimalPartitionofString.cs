namespace LeetCodeTasks._2405OptimalPartitionofString
{
    public class OptimalPartitionofString
    {
        public int PartitionString(string s)
        {
            var result = 1;
            var set = new HashSet<char>();
            foreach (char c in s)
            {
                if (set.Contains(c))
                {
                    result++;
                    set.Clear();
                }

                set.Add(c);
            }

            return result;
        }
    }
}
