namespace LeetCodeTasks._2418SortthePeople
{
    public class SortthePeople
    {
        public string[] SortPeople(string[] names, int[] heights)
        {
            //return Csharp(names, heights);
            return Pairing(names, heights);
        }

        private string[] Pairing(string[] names, int[] heights)
        {
            var arr = new KeyValuePair<int, string>[names.Length];
            for (int i = 0; i < names.Length; i++)
                arr[i] = new KeyValuePair<int, string>(heights[i], names[i]);

            Array.Sort(arr, Comparer<KeyValuePair<int, string>>.Create((a, b) => b.Key.CompareTo(a.Key)));
            for (var i = 0; i < names.Length; i++)
                names[i] = arr[i].Value;

            return names;
        }

        private string[] Csharp(string[] names, int[] heights)
        {
            Array.Sort(heights, names, Comparer<int>.Create((a, b) => b.CompareTo(a)));
            return names;
        }
    }
}
