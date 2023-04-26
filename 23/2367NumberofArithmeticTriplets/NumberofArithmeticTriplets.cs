namespace LeetCodeTasks._2367NumberofArithmeticTriplets
{
    public class NumberofArithmeticTriplets
    {
        public int ArithmeticTriplets(int[] nums, int diff)
        {
            var count = 0;
            var set = new HashSet<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i] - diff) && set.Contains(nums[i] - 2 * diff))
                {
                    count++;
                }
                set.Add(nums[i]);
            }

            return count;
        }

        public int ArithmeticTripletsBS(int[] nums, int diff)
        {
            var count = 0;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                var l = i;
                var r = nums.Length - 2;
                while (l <= r)
                {
                    var mid = l + (r - l) / 2;
                    var delta = nums[mid] - nums[i];
                    if (delta == diff)
                    {
                        l = mid;
                        break;
                    }
                    else if (delta > diff) r = mid - 1;
                    else l = mid + 1;
                }

                if (l > nums.Length - 1) continue;
                if (nums[l] - nums[i] != diff) continue;

                var j = l;
                r = nums.Length - 1;
                while (l <= r)
                {
                    var mid = l + (r - l) / 2;
                    var delta = nums[mid] - nums[j];
                    if (delta == diff)
                    {
                        l = mid;
                        break;
                    }
                    else if (delta > diff) r = mid - 1;
                    else l = mid + 1;
                }

                if (l > nums.Length - 1) continue;
                if (nums[l] - nums[j] != diff) continue;

                count++;
            }

            return count;
        }
    }
}
