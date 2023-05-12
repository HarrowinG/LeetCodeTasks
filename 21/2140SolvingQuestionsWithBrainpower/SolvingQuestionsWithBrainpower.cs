namespace LeetCodeTasks._2140SolvingQuestionsWithBrainpower
{
    public class SolvingQuestionsWithBrainpower
    {
        public long MostPoints(int[][] questions)
        {
            var dp = new long[questions.Length + 1];
            for (var i = questions.Length - 1; i >= 0; i--)
            {
                var points = questions[i][0];
                var power = questions[i][1];

                dp[i] = points;
                var nextId = i + power + 1;
                if (nextId < questions.Length) 
                    dp[i] += dp[nextId];

                dp[i] = Math.Max(dp[i], dp[i + 1]);
            }

            return dp[0];
        }
    }
}
