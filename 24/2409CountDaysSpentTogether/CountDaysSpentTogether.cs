namespace LeetCodeTasks._2409CountDaysSpentTogether
{
    public class CountDaysSpentTogether
    {
        private int[] monthesDays = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
        {
            for (var i = 1; i < monthesDays.Length; i++)
            {
                monthesDays[i] += monthesDays[i - 1];
            }

            var start = Math.Max(Days(arriveAlice), Days(arriveBob));
            var end = Math.Min(Days(leaveAlice), Days(leaveBob));

            return Math.Max(0, end - start + 1);
        }

        private int Days(string date)
        {
            return monthesDays[10 * (date[0] - '0') + date[1] - '0' - 1] + 10 * (date[3] - '0') + date[4] - '0';
        }
    }
}
