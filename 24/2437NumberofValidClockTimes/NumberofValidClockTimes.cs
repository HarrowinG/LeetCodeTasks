namespace LeetCodeTasks._2437NumberofValidClockTimes
{
    public class NumberofValidClockTimes
    {
        public int CountTime(string time)
        {
            var result = 1;
            if (time[0] == '?')
            {
                if (time[1] == '?') result *= 24;
                else if (time[1] - '0' < 4) result *= 3;
                else result *= 2;
            }
            else if (time[1] == '?')
            {
                if (time[0] - '0' < 2) result *= 10;
                else result *= 4;
            }

            if (time[3] == '?') result *= 6;
            if (time[4] == '?') result *= 10;

            return result;
        }
    }
}
