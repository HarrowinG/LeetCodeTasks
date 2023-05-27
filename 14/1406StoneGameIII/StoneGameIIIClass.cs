namespace LeetCodeTasks._1406StoneGameIII
{
    public class StoneGameIIIClass
    {
        public string StoneGameIII(int[] stoneValue)
        {
            var dp = new int[4];
            for (var i = stoneValue.Length - 1; i >= 0; i--)
            {
                dp[i % 4] = int.MinValue;
                var score = 0;
                for (var taken = 0; taken < 3; taken++)
                {
                    if (i + taken >= stoneValue.Length) break;

                    score += stoneValue[i + taken];
                    dp[i % 4] = Math.Max(dp[i % 4], score - dp[(i + taken + 1) % 4]);
                }
            }

            if (dp[0] > 0) return "Alice";
            if (dp[0] < 0) return "Bob";
            return "Tie";
        }
    }
}
