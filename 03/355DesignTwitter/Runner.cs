using LeetCodeTasks.Utility;

namespace LeetCodeTasks._355DesignTwitter
{
    public class Runner
    {
        public void Run()
        {
            /*
            Twitter twitter = new Twitter();
            twitter.PostTweet(1, 5); // User 1 posts a new tweet (id = 5).
            Console.WriteLine(ResultUtility.List(twitter.GetNewsFeed(1)));  // User 1's news feed should return a list with 1 tweet id -> [5]. return [5]
            twitter.Follow(1, 2);    // User 1 follows user 2.
            twitter.PostTweet(2, 6); // User 2 posts a new tweet (id = 6).
            Console.WriteLine(ResultUtility.List(twitter.GetNewsFeed(1)));  // User 1's news feed should return a list with 2 tweet ids -> [6, 5]. Tweet id 6 should precede tweet id 5 because it is posted after tweet id 5.
            twitter.Unfollow(1, 2);  // User 1 unfollows user 2.
            Console.WriteLine(ResultUtility.List(twitter.GetNewsFeed(1)));  // User 1's news feed should return a list with 1 tweet id -> [5], since user 1
            */
            /*
            Twitter twitter = new Twitter();
            twitter.PostTweet(1, 1);
            twitter.PostTweet(1, 2);
            twitter.PostTweet(1, 3);
            twitter.PostTweet(1, 4);
            twitter.PostTweet(1, 5);
            Console.WriteLine(ResultUtility.List(twitter.GetNewsFeed(1)));
            twitter.Follow(1, 2);
            twitter.PostTweet(2, 6);
            twitter.PostTweet(2, 7);
            twitter.PostTweet(2, 8);
            twitter.PostTweet(2, 9);
            twitter.PostTweet(2, 10);
            twitter.PostTweet(2, 11);
            Console.WriteLine(ResultUtility.List(twitter.GetNewsFeed(1)));
            twitter.Unfollow(1, 2);
            twitter.Follow(1, 3);
            twitter.PostTweet(3, 20);
            Console.WriteLine(ResultUtility.List(twitter.GetNewsFeed(1)));
            */

            Twitter twitter = new Twitter();
            twitter.Follow(1, 5);
            Console.WriteLine(ResultUtility.List(twitter.GetNewsFeed(1)));
        }
    }
}
