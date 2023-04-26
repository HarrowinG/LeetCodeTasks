using System.Text;

namespace LeetCodeTasks._43MultiplyStrings
{
    public class MultiplyStrings
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") return "0";

            var array = new int[num1.Length + num2.Length];
            for (var i = num1.Length - 1; i >= 0; i--)
            {
                for (var j = num2.Length - 1; j >= 0; j--)
                {
                    var multRes = (num1[i] - '0') * (num2[j] - '0');
                    array[i + j + 1] += multRes;
                    array[i + j] += array[i + j + 1] / 10;
                    array[i + j + 1] %= 10;
                }
            }

            var id = 0;
            while (array[id] == 0) id++;

            var sb = new StringBuilder();
            for (; id < array.Length; id++)
                sb.Append(array[id]);

            return sb.ToString();
        }
    }
}
