namespace LeetCodeTasks._355DesignTwitter
{
    public class Twitter
    {
        private Dictionary<int, HashSet<int>> _folowers = new();
        private Dictionary<int, List<(int TweetId, DateTime DateTime)>> _tweets = new();

        public Twitter()
        {

        }

        public void PostTweet(int userId, int tweetId)
        {
            _tweets[userId] = _tweets.GetValueOrDefault(userId, new List<(int, DateTime)>());
            _tweets[userId].Add((tweetId, DateTime.Now));
        }

        public IList<int> GetNewsFeed(int userId)
        {
            var queue = new PriorityQueue<(int userId, int id), DateTime>(Comparer<DateTime>.Create((a, b) => b.CompareTo(a)));

            if (_tweets.ContainsKey(userId))
                if (_tweets[userId].Count > 0)
                    queue.Enqueue((userId, _tweets[userId].Count - 1), _tweets[userId].Last().DateTime);
            
            if (_folowers.ContainsKey(userId))
                foreach (var followeeId in _folowers[userId])
                    if (_tweets.ContainsKey(followeeId))
                        if (_tweets[followeeId].Count > 0)
                            queue.Enqueue((followeeId, _tweets[followeeId].Count - 1), _tweets[followeeId].Last().DateTime);

            var result = new List<int>();
            for (var k = 0; k < 10 && queue.Count > 0; k++)
            {
                var item = queue.Dequeue();
                result.Add(_tweets[item.userId][item.id].TweetId);
                if (item.id > 0)
                {
                    item.id--;
                    queue.Enqueue(item, _tweets[item.userId][item.id].DateTime);
                }
            }

            return result;
        }

        public void Follow(int followerId, int followeeId)
        {
            _folowers[followerId] = _folowers.GetValueOrDefault(followerId, new HashSet<int>());
            _folowers[followerId].Add(followeeId);
        }

        public void Unfollow(int followerId, int followeeId)
        {
            if (_folowers.ContainsKey(followerId))
            {
                _folowers[followerId].Remove(followeeId);
            }
        }
    }
}
