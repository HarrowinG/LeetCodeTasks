namespace LeetCodeTasks._2424LongestUploadedPrefix
{
    public class LUPrefix
    {
        HashSet<int> _prefixes;
        int _id = 0;
        public LUPrefix(int n)
        {
            _prefixes = new HashSet<int>();
        }

        public void Upload(int video)
        {
            _prefixes.Add(video);
            while (_prefixes.Contains(_id + 1)) _id++;
        }

        public int Longest()
        {
            return _id;
        }
    }
}
