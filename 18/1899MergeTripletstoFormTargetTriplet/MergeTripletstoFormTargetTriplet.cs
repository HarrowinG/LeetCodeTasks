namespace LeetCodeTasks._1899MergeTripletstoFormTargetTriplet
{
    public class MergeTripletstoFormTargetTriplet
    {
        public bool MergeTriplets(int[][] triplets, int[] target)
        {
            var res = new bool[3];
            foreach (var triplet in triplets)
            {
                if (triplet[0] > target[0] || triplet[1] > target[1] || triplet[2] > target[2]) continue;

                res[0] |= triplet[0] == target[0];
                res[1] |= triplet[1] == target[1];
                res[2] |= triplet[2] == target[2];

                if (res[0] && res[1] && res[2]) return true;
            }

            return false;
        }
    }
}
