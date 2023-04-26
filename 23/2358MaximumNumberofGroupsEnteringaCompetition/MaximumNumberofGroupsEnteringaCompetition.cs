namespace LeetCodeTasks._2358MaximumNumberofGroupsEnteringaCompetition
{
    public class MaximumNumberofGroupsEnteringaCompetition
    {
        public int MaximumGroups1(int[] grades)
        {
            var sum = 0;
            int k = 0;
            while (sum + k + 1 <= grades.Length)
            {
                sum += ++k;
            }

            return k;
        }

        public int MaximumGroups(int[] grades)
        {
            //1000 because max length 100000
            int left = 0, right = 1000, n = grades.Length;
            while (left < right)
            {
                int k = (left + right + 1) / 2;
                if (k * (k + 1) / 2 > n)
                {
                    right = k - 1;
                }
                else
                {
                    left = k;
                }
            }
            return left;
        }
    }
}
