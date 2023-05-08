namespace LeetCodeTasks._1964FindtheLongestValidObstacleCourseatEachPosition
{
    public class FindtheLongestValidObstacleCourseatEachPosition
    {
        public int[] LongestObstacleCourseAtEachPosition(int[] obstacles)
        {
            var result = new int[obstacles.Length];
            result[0] = 1;
            var seq = new List<int> { obstacles[0] };
            for (var i = 1; i < obstacles.Length; i++)
            {
                var obstacle = obstacles[i];
                if (obstacle >= seq[seq.Count - 1])
                {
                    seq.Add(obstacle);
                    result[i] = seq.Count;
                    continue;
                }

                var index = BinarySearch(seq, obstacle);
                seq[index] = obstacle;
                result[i] = index + 1;
            }

            return result;
        }

        private int BinarySearch(List<int> seq, int num)
        {
            var l = 0;
            var r = seq.Count - 1;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                if (seq[mid] <= num) l = mid + 1;
                else r = mid - 1;
            }

            return l;
        }
    }
}
