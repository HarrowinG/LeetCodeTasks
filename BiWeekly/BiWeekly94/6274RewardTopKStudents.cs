using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.BiWeekly94
{
    public class _6274RewardTopKStudents
    {
        public IList<int> TopStudents(string[] positive_feedback, string[] negative_feedback, string[] report, int[] student_id, int k)
        {
            var result = new List<int>();
            var pf = positive_feedback.ToHashSet();
            var nf = negative_feedback.ToHashSet();
            var comparer = Comparer<(int Score, int Id)>.Create(
                (a, b) => a.Score == b.Score 
                    ? a.Id.CompareTo(b.Id)
                    : b.Score.CompareTo(a.Score));
            var queue = new PriorityQueue<(int Score, int Id), (int Score, int Id)>(comparer);
            for (var i = 0; i < report.Length; i++)
            {
                var score = 0;
                var rep = report[i];
                var words = rep.Split(' ');
                foreach (var word in words)
                {
                    if (pf.Contains(word)) score += 3;
                    if (nf.Contains(word)) score--;
                }

                var item = (score, student_id[i]);
                queue.Enqueue(item, item);
            }

            while (k > 0)
            {
                result.Add(queue.Dequeue().Id);
                k--;
            }

            return result;
        }
    }
}
