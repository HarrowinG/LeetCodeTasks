namespace LeetCodeTasks._846HandofStraights
{
    public class HandofStraights
    {
        public bool IsNStraightHand(int[] hand, int groupSize)
        {
            //return IsNStraightHandNormal(hand, groupSize);
            return IsNStraightHandOptimized(hand, groupSize);
        }

        public bool IsNStraightHandOptimized(int[] hand, int groupSize)
        {
            if (hand.Length % groupSize != 0) return false;

            var dict = new SortedDictionary<int, int>();
            for (var i = 0; i < hand.Length; i++)
                dict[hand[i]] = dict.GetValueOrDefault(hand[i], 0) + 1;

            var queue = new Queue<int>();
            var lastChecked = -1;
            var numberToDecrease = 0;
            foreach (var key in dict.Keys.ToList())
            {
                if (numberToDecrease > 0 && key > lastChecked + 1 || numberToDecrease > dict[key]) return false;

                queue.Enqueue(dict[key] - numberToDecrease);
                lastChecked = key;
                numberToDecrease = dict[key];
                if (queue.Count == groupSize) 
                    numberToDecrease -= queue.Dequeue();
            }

            return numberToDecrease == 0;
        }

        public bool IsNStraightHandNormal(int[] hand, int groupSize)
        {
            if (hand.Length % groupSize != 0) return false;

            var dict = new SortedDictionary<int, int>();
            for (var i = 0; i < hand.Length; i++)
                dict[hand[i]] = dict.GetValueOrDefault(hand[i], 0) + 1;

            foreach (var key in dict.Keys.ToList())
            {
                if (dict[key] <= 0) continue;

                for (var i = groupSize - 1; i >= 0; i--)
                {
                    if (dict.GetValueOrDefault(key + i, 0) < dict[key]) return false;
                    dict[key + i] -= dict[key];
                }
            }

            return true;
        }
    }
}
