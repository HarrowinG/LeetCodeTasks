namespace LeetCodeTasks._2410MaximumMatchingofPlayersWithTrainers
{
    public class MaximumMatchingofPlayersWithTrainers
    {
        public int MatchPlayersAndTrainers(int[] players, int[] trainers)
        {
            var count = 0;
            Array.Sort(players);
            Array.Sort(trainers);

            var p = 0;
            var t = 0;
            while (p < players.Length && t < trainers.Length)
            {
                if (players[p] > trainers[t])
                    while (t < trainers.Length && trainers[t] < players[p])
                        t++;
                else
                {
                    count++;
                    p++;
                    t++;
                }
            }

            return count;
        }
    }
}
