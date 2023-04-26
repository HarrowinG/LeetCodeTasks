namespace LeetCodeTasks._49GroupAnagrams
{
    public class GroupAnagramsClass
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();
            for (var i = 0; i < strs.Length; i++)
            {
                var key = new char[26];
                foreach (var c in strs[i])
                {
                    key[c - 'a']++;
                }

                var strKey = new string(key);
                dict[strKey] = dict.GetValueOrDefault(strKey, new List<string>());
                dict[strKey].Add(strs[i]);
            }

            return dict.Values.ToList();
        }
    }
}
