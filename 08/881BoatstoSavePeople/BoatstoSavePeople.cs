namespace LeetCodeTasks._881BoatstoSavePeople
{
    public class BoatstoSavePeople
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            var result = 0;
            var l = 0; var r = people.Length - 1;
            Array.Sort(people);

            while (l <= r)
            {
                if (people[l] + people[r] <= limit)
                {
                    l++;
                    r--;
                }
                else r--;

                result++;
            }

            return result;
        }
    }
}
