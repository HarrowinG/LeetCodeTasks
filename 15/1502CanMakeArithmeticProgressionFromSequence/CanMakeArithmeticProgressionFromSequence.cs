namespace LeetCodeTasks._1502CanMakeArithmeticProgressionFromSequence
{
    public class CanMakeArithmeticProgressionFromSequence
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            var delta = arr[1] - arr[0];
            for (var i = 2; i < arr.Length; i++)
                if (arr[i] - arr[i - 1] != delta) return false;

            return true;
        }
    }
}
