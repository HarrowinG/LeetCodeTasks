namespace LeetCodeTasks._2425BitwiseXORofAllPairings
{
    public class BitwiseXORofAllPairings
    {
        public int XorAllNums(int[] nums1, int[] nums2)
        {
            var res = 0;
            if (nums1.Length % 2 != 0)
                for (var i = 0; i < nums2.Length; i++)
                    res ^= nums2[i];

            if (nums2.Length % 2 != 0)
                for (var i = 0; i < nums1.Length; i++)
                    res ^= nums1[i];

            return res;
        }
    }
}
