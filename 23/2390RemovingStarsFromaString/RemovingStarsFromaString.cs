namespace LeetCodeTasks._2390RemovingStarsFromaString
{
    public class RemovingStarsFromaString
    {
        public string RemoveStars(string s)
        {
            var arr = s.ToCharArray();
            var j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*') j--;
                else arr[j++] = s[i];
            }

            return new string(arr, 0, j);
        }
    }
}
