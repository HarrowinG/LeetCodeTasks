namespace LeetCodeTasks._4MedianofTwoSortedArrays
{
    public class MedianofTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var smaller = nums1.Length < nums2.Length ? nums1 : nums2;
            var larger = smaller == nums1 ? nums2 : nums1;
            var total = smaller.Length + larger.Length;
            var half = total / 2;

            var l = 0; var r = smaller.Length - 1;
            while (true)
            {
                var smallId = r - l < 0 ? -1 : l + (r - l) / 2;
                var largeId = half - smallId - 2;
                
                var smallLeft = smallId >= 0 ? smaller[smallId] : int.MinValue;
                var smallRight = smallId + 1 < smaller.Length ? smaller[smallId + 1] : int.MaxValue;
                var largeLeft = largeId >= 0 ? larger[largeId] : int.MinValue;
                var largeRight = largeId + 1 < larger.Length ? larger[largeId + 1] : int.MaxValue;

                if (smallLeft <= largeRight && largeLeft <= smallRight)
                {
                    if (total % 2 == 0)
                        return (Math.Max(smallLeft, largeLeft) + Math.Min(smallRight, largeRight)) / 2.0;
                    else 
                        return Math.Min(smallRight, largeRight);
                }

                if (smallLeft > largeRight) r = smallId - 1;
                else l = smallId + 1;
            }
        }
    }
}
