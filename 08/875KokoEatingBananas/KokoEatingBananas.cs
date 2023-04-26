namespace LeetCodeTasks._875KokoEatingBananas
{
    public class KokoEatingBananas
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            var l = 1;
            var r = piles.Max();
            while (l <= r)
            {
                var hours = 0L;
                var mid = l + (r - l) / 2;
                for (var i = 0; i < piles.Length; i++)
                {
                    hours += piles[i] / mid;
                    if (piles[i] % mid != 0) hours++;
                }

                if (hours > h) l = mid + 1;
                else r = mid - 1;
            }

            return l;
        }
    }
}
