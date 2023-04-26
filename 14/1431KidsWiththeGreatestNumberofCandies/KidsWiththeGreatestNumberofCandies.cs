using System.Net.Http.Headers;

namespace LeetCodeTasks._1431KidsWiththeGreatestNumberofCandies
{
    public class KidsWiththeGreatestNumberofCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var result = new List<bool>();
            var max = candies.Max();
            foreach (var candy in candies)
                result.Add(candy + extraCandies >= max);

            return result;
        }
    }
}
