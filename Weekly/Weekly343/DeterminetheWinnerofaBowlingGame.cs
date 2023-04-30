using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly343
{
    public class DeterminetheWinnerofaBowlingGame
    {
        public int IsWinner(int[] player1, int[] player2)
        {
            if (player1.Length == 1) 
                return player1[0] == player2[0] ? 0 
                    : player1[0] > player2[0] ? 1 : 2;

            var sum1 = player1[0];
            var sum2 = player2[0];
            sum1 += sum1 == 10 ? 2 * player1[1] : player1[1];
            sum2 += sum2 == 10 ? 2 * player2[1] : player2[1];

            for (var i = 2; i < player1.Length; i++)
            {
                if (player1[i - 1] == 10 || player1[i - 2] == 10)
                    sum1 += 2 * player1[i];
                else sum1 += player1[i];

                if (player2[i - 1] == 10 || player2[i - 2] == 10)
                    sum2 += 2 * player2[i];
                else sum2 += player2[i];
            }

            return sum1 == sum2 ? 0
                    : sum1 > sum2 ? 1 : 2;
        }
    }
}
