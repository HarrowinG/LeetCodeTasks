namespace LeetCodeTasks._2215FindtheDifferenceofTwoArrays
{
    public class FindtheDifferenceofTwoArrays
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var result = new List<IList<int>>();
            var set1 = nums1.ToHashSet();
            var set2 = nums2.ToHashSet();
            result.Add(set1.Except(set2).ToList());
            result.Add(set2.Except(set1).ToList());

            return result;
        }
    }
}
