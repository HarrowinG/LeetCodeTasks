using System.Text;

namespace LeetCodeTasks._271EncodeandDecodeStrings
{
    //preminum
    public class EncodeandDecodeStrings
    {
        public string encode(List<string> strs)
        {
            var sb = new StringBuilder();
            foreach (var str in strs)
            {
                sb.Append($"{str.Length}#");
                sb.Append(str);
            }

            return sb.ToString();
        }

        public List<string> decode(string str)
        {
            var result = new List<string>();
            var i = 0;
            while (i < str.Length)
            {
                var sharpId = str.IndexOf('#', i);

                var num = int.Parse(str.Substring(i, sharpId - i));
                result.Add(str.Substring(sharpId + 1, num));
                i = sharpId + num + 1;
            }

            return result;
        }
    }
}
