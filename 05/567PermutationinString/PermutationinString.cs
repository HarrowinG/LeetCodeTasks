namespace LeetCodeTasks._567PermutationinString
{
    public class PermutationinString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s2.Length < s1.Length) return false;

            var lettersDiff = 0;
            var s1Count = new int[26];
            var s2Count = new int[26];
            for (var i = 0; i < s1.Length; i++)
            {
                s1Count[s1[i] - 'a']++;
                s2Count[s2[i] - 'a']++;
            }
            for (var i = 0; i < 26; i++)
                if (s1Count[i] != s2Count[i]) lettersDiff++;

            if (lettersDiff == 0) return true;

            for (var i = s1.Length; i < s2.Length; i++)
            {
                var removedId = s2[i - s1.Length] - 'a';
                var addedId = s2[i] - 'a';
                if (removedId == addedId) continue;

                if (s2Count[removedId] - 1 == s1Count[removedId]) lettersDiff--;
                else if (s2Count[removedId] == s1Count[removedId]) lettersDiff++;
                s2Count[removedId]--;

                if (s2Count[addedId] + 1 == s1Count[addedId]) lettersDiff--;
                else if (s2Count[addedId] == s1Count[addedId]) lettersDiff++;
                s2Count[addedId]++;

                if (lettersDiff == 0) return true;
            }

            return false;
        }
    }
}
