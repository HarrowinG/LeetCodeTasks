namespace LeetCodeTasks.Utility
{
    public static class InputUtility
    {
        public static IList<int> StringToIntList(string s)
        {
            var list = new List<int>();
            s = s.Remove(0, 1);
            s = s.Remove(s.Length - 1, 1);
            for (int i = 0; i < s.Length; i++)
            {
                var commaPos = s.IndexOf(',', i);
                if (commaPos == -1)
                {
                    list.Add(int.Parse(s.Substring(i, s.Length - i)));
                    break;
                }
                else
                {
                    list.Add(int.Parse(s.Substring(i, commaPos - i)));
                    i = commaPos;
                }
            }

            return list;
        }

        public static int[] StringToIntArray(string s)
        {
            return StringToIntList(s).ToArray();
        }

        public static IList<IList<int>> StringToIntList2D(string s)
        {
            var list = new List<IList<int>>();
            s = s.Remove(0, 1);
            s = s.Remove(s.Length - 1, 1);
            for (int i = 0; i < s.Length; i++)
            {
                var bracePos = s.IndexOf(']', i);
                if (bracePos == -1) break;

                list.Add(StringToIntArray(s.Substring(i, bracePos - i + 1)));
                i = bracePos + 1;
            }

            return list;
        }

        public static int[][] StringToIntArray2D(string s)
        {
            var list = new List<int[]>();
            var res = StringToIntList2D(s);
            foreach (var item in res)
                list.Add(item.ToArray());

            return list.ToArray();
        }

        public static int?[] StringToNullIntArray(string s)
        {
            var list = new List<int?>();
            s = s.Remove(0, 1);
            s = s.Remove(s.Length - 1, 1);
            for (int i = 0; i < s.Length; i++)
            {
                var commaPos = s.IndexOf(',', i);
                if (commaPos == -1)
                {
                    if (int.TryParse(s.Substring(i, s.Length - i), out var num))
                    {
                        list.Add(num);
                    }
                    else
                    {
                        list.Add(null);
                    }
                    break;
                }
                else
                {
                    if (int.TryParse(s.Substring(i, commaPos - i), out var num))
                    {
                        list.Add(num);
                    }
                    else
                    {
                        list.Add(null);
                    }
                    i = commaPos;
                }
            }

            return list.ToArray();
        }
    }
}
