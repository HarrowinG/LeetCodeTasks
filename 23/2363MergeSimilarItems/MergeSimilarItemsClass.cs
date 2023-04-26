namespace LeetCodeTasks._2363MergeSimilarItems
{
    public class MergeSimilarItemsClass
    {
        public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
        {
            var dict = new SortedDictionary<int, int>();
            foreach (var item in items1)
            {
                dict.Add(item[0], item[1]);
            }
            foreach (var item in items2)
            {
                if (dict.ContainsKey(item[0]))
                {
                    dict[item[0]] += item[1];
                }
                else
                {
                    dict.Add(item[0], item[1]);
                }
            }

            var result = new List<IList<int>>();
            foreach (var item in dict)
            {
                result.Add(new List<int> { item.Key, item.Value });
            }

            return result;
        }

        public IList<IList<int>> MergeSimilarItems2(int[][] items1, int[][] items2)
        {
            var result = new List<IList<int>>();
            Array.Sort(items1, (a, b) => a[0].CompareTo(b[0]));
            Array.Sort(items2, (a, b) => a[0].CompareTo(b[0]));
            var i = 0; var j = 0;
            while (i < items1.Length && j < items2.Length)
            {
                if (items1[i][0] == items2[j][0])
                {
                    result.Add(new int[] { items1[i][0], items1[i][1] + items2[j][1] });
                    i++; j++;
                }
                else if (items1[i][0] < items2[j][0])
                {
                    result.Add(items1[i]);
                    i++;
                }
                else
                {
                    result.Add(items2[j]);
                    j++;
                }
            }

            while (i < items1.Length)
            {
                result.Add(items1[i]);
                i++;
            }
            while (j < items2.Length)
            {
                result.Add(items2[j]);
                j++;
            }

            return result;
        }
    }
}
