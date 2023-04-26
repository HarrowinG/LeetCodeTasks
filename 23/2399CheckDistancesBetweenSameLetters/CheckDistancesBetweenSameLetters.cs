namespace LeetCodeTasks._2399CheckDistancesBetweenSameLetters
{
    public class CheckDistancesBetweenSameLetters
    {
        public bool CheckDistances(string s, int[] distance)
        {
            for (int i = 0; i < s.Length; i++)
            {
                var id = s[i] - 'a';
                var nextId = i + distance[id] + 1;
                if (nextId >= s.Length || s[i] != s[nextId]) return false;
                distance[id] = -1;
            }

            return true;
        }
    }
}
