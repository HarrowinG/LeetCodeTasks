using System.Text;

namespace LeetCodeTasks._17LetterCombinationsofaPhoneNumber
{
    public class LetterCombinationsofaPhoneNumber
    {
        private Dictionary<char, string> _map = new Dictionary<char, string>
        {
            ['2'] = "abc",
            ['3'] = "def",
            ['4'] = "ghi",
            ['5'] = "jkl",
            ['6'] = "mno",
            ['7'] = "pqrs",
            ['8'] = "tuv",
            ['9'] = "wxyz"
        };

        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits)) return new List<string>();

            var result = new List<string>();
            Dfs(new StringBuilder(4), result, digits, 0);
            return result;
        }

        private void Dfs(StringBuilder current, IList<string> result, string digits, int id)
        {
            if (id == digits.Length)
            {
                result.Add(current.ToString());
                return;
            }

            var letters = _map[digits[id]];
            foreach (var letter in letters)
            {
                current.Append(letter);
                Dfs(current, result, digits, id + 1);
                current.Remove(current.Length - 1, 1);
            }
        }
    }
}
