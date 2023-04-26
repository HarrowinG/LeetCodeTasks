namespace LeetCodeTasks._2433FindTheOriginalArrayofPrefixXor
{
    public class FindTheOriginalArrayofPrefixXor
    {
        public int[] FindArray(int[] pref)
        {
            var result = new int[pref.Length];
            result[0] = pref[0];
            for (var i = 1; i < pref.Length; i++)
            {
                result[i] = pref[i] ^ pref[i - 1];
            }

            return result;
        }
    }
}
