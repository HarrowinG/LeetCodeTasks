namespace LeetCodeTasks._2391MinimumAmountofTimetoCollectGarbage
{
    public class MinimumAmountofTimetoCollectGarbage
    {
        public int GarbageCollection(string[] garbage, int[] travel)
        {
            var sum = 0;
            var last = new int[128];
            for (int i = 0; i < garbage.Length; i++)
            {
                sum += garbage[i].Length;
                for (int j = 0; j < garbage[i].Length; j++)
                {
                    last[garbage[i][j]] = i;
                }
            }

            for (int j = 1; j < travel.Length; j++)
            {
                travel[j] += travel[j - 1];
            }

            foreach (var c in "PGM".ToCharArray())
            {
                if (last[c] > 0)
                {
                    sum += travel[last[c] - 1];
                }
            }

            return sum;
        }
    }
}
