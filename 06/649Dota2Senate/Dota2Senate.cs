namespace LeetCodeTasks._649Dota2Senate
{
    public class Dota2Senate
    {
        public string PredictPartyVictory(string senate)
        {
            var radiant = new Queue<int>();
            var dire = new Queue<int>();
            for (var i = 0; i < senate.Length; i++)
                if (senate[i] == 'R') radiant.Enqueue(i);
                else dire.Enqueue(i);

            while (radiant.Count > 0 && dire.Count > 0)
            {
                var r = radiant.Dequeue();
                var d = dire.Dequeue();
                if (r < d) radiant.Enqueue(r + senate.Length);
                else dire.Enqueue(d + senate.Length);
            }

            return radiant.Count > dire.Count ? "Radiant" : "Dire";
        }
    }
}
