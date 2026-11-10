        public class Twitter
        {

            Dictionary<int, HashSet<int>> users;
            LinkedList<(int userId, int tweetId)> tweets;

            public Twitter()
            {
                users = new Dictionary<int, HashSet<int>>();
                tweets = new LinkedList<(int userId, int tweetId)>();
            }

            public void PostTweet(int userId, int tweetId)
            {
                if (!users.ContainsKey(userId))
                {
                    users.Add(userId, new HashSet<int>());
                }

                tweets.AddFirst((userId, tweetId));

            }

            public List<int> GetNewsFeed(int userId)
            {
                List<int> newsList = new List<int>(10);

                foreach(var tweet in tweets)
                {
                    if (users[userId].Contains(tweet.userId) || userId == tweet.userId)
                    {
                        newsList.Add(tweet.tweetId);
                        if (newsList.Count == 10) return newsList;
                    }
                }

                return newsList;
            }

            public void Follow(int followerId, int followeeId)
            {

                if (followerId != followeeId)
                {
                    if (!users.ContainsKey(followerId))
                    {
                        users.Add(followerId, new HashSet<int>());
                    }

                    if (!users.ContainsKey(followeeId))
                    {
                        users.Add(followeeId, new HashSet<int>());
                    }

                    users[followerId].Add(followeeId);
                }
            }

            public void Unfollow(int followerId, int followeeId)
            {

                if (followerId != followeeId)
                {

                    if (users.ContainsKey(followerId))
                    {
                        users[followerId].Remove(followeeId);
                    }

                }
            }
        }