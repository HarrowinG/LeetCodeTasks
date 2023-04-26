using System.Text;

namespace LeetCodeTasks._838PushDominoes
{
    public class PushDominoesClass
    {
        public string PushDominoes(string dominoes)
        {
            var sb = new StringBuilder(dominoes);
            var r = -1;
            for (var i = 0; i < dominoes.Length; i++)
            {
                if (dominoes[i] == 'L')
                {
                    if (r != -1)
                    {
                        r++;
                        var l = i - 1;
                        while (r < l)
                        {
                            sb[r] = 'R';
                            sb[l] = 'L';
                            r++;
                            l--;
                        }

                        r = -1;
                    }
                    else
                        for (var j = i - 1; j >= 0 && dominoes[j] == '.'; j--)
                            sb[j] = 'L';
                }
                else if (dominoes[i] == 'R')
                {
                    if (r != -1)
                        for (; r < i; r++)
                            sb[r] = 'R';
                    r = i;
                }
            }

            if (r != -1)
                for (; r < dominoes.Length; r++)
                    sb[r] = 'R';

            return sb.ToString();
        }
    }
}
