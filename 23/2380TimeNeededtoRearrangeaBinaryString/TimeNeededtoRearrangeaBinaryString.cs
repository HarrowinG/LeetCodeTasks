namespace LeetCodeTasks._2380TimeNeededtoRearrangeaBinaryString
{
    public class TimeNeededtoRearrangeaBinaryString
    {
        public int SecondsToRemoveOccurrences(string s)
        {
            var zeros = 0;
            var seconds = 0;
            for (int i = 0; i < s.Length; i++)
            {
                zeros += s[i] == '0' ? 1 : 0;
                if (s[i] == '1' && zeros > 0)
                {
                    seconds = Math.Max(seconds + 1, zeros);
                }
            }

            return seconds;
        }
    }
}
