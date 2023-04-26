namespace LeetCodeTasks._2374NodeWithHighestEdgeScore
{
    public class NodeWithHighestEdgeScore
    {
        public int EdgeScore(int[] edges)
        {
            var id = 0;
            var scores = new long[edges.Length];
            for (var i = 0; i < edges.Length; i++)
            {
                scores[edges[i]] += i;
            }

            long max = 0;
            for (var i = 0; i < scores.Length; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                    id = i;
                }
            }

            return id;
        }
    }
}
