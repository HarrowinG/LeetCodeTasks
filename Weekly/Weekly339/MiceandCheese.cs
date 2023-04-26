using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly339
{
    public class MiceandCheese
    {
        public int MiceAndCheese(int[] reward1, int[] reward2, int k)
        {
            var result = 0;
            var sum2 = reward2.Sum();

            var eatenSums = Eat(reward1, reward2, sum2);
            eatenSums.Sort(Comparer<(int Sum, int Id)>.Create((a,b) => b.Sum.CompareTo(a.Sum)));
            for (var i = 0; i < k; i++)
            {
                var id = eatenSums[i].Id;
                sum2 -= reward2[id];
                result += reward1[id];
            }

            return result + sum2;
        }

        private List<(int Sum, int Id)> Eat(int[] reward1, int[] reward2, int sum2)
        {
            var list = new List<(int Sum, int Id)>();
            for (var i = 0; i < reward1.Length; i++)
            {
                var sum = reward1[i] + sum2 - reward2[i];
                list.Add((sum, i));
            }

            return list;
        }
    }
}
