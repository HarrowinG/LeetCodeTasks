namespace LeetCodeTasks._2379MinimumRecolorstoGetKConsecutiveBlackBlocks
{
    public class MinimumRecolorstoGetKConsecutiveBlackBlocks
    {
        public int MinimumRecolors(string blocks, int k)
        {
            var wInScope = 0;
            for (var i = 0; i < k; i++)
            {
                if (blocks[i] == 'W') wInScope++;
            }

            var min = wInScope;
            if (min == 0) return 0;

            for (var i = k; i < blocks.Length; i++)
            {
                if (blocks[i] == 'W') wInScope++;
                if (blocks[i - k] == 'W') wInScope--;
                min = Math.Min(min, wInScope);
                if (min == 0) return 0;
            }

            return min;
        }
    }
}
