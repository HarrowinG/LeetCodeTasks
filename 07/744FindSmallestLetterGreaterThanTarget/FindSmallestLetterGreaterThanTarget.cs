namespace LeetCodeTasks._744FindSmallestLetterGreaterThanTarget
{
    public class FindSmallestLetterGreaterThanTarget
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            var l = 0; var r = letters.Length - 1;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                if (letters[mid] <= target) l = mid + 1;
                else r = mid - 1;
            }

            return l == letters.Length ? letters[0] : letters[l];
        }
    }
}
