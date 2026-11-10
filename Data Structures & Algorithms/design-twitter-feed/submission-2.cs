        public class User
        {
            public int UserId { get; set; }
            public HashSet<int> Followees { get; set; }
            public LinkedList<(int tweetId, int count)> Tweets { get; set; }

            public User(int userId)
            {
                UserId = userId;
                Tweets = new LinkedList<(int tweetId, int count)>();
                Followees = new HashSet<int>();
            }
        }

        public class Twitter
        {

            private Dictionary<int, User> _users;
            private int _tweetCount = 0;
            private const int _newsFeedSize = 10;

            public Twitter()
            {

                _users = new Dictionary<int, User>();
            }

            public void PostTweet(int userId, int tweetId)
            {
                if (!_users.ContainsKey(userId))
                {
                    User user = new User(userId);
                    _users.Add(userId, user);
                    _users[userId].Followees.Add(userId);
                }

                _users[userId].Tweets.AddFirst((tweetId, _tweetCount++));
            }

            public List<int> GetNewsFeed(int userId)
            {
                var q = new PriorityQueue<int, int>(comparer: Comparer<int>.Create((a, b) => b.CompareTo(a)));
                List<int> newsList = new List<int>(_newsFeedSize);
                int i = 0;

                if (_users.ContainsKey(userId))
                {
                    foreach(var user in _users[userId].Followees)
                    {
                        var followeeTweets = _users[user].Tweets;
                        int maxTweets = followeeTweets.Count < _newsFeedSize ? followeeTweets.Count : _newsFeedSize;
                        i = 0;

                        foreach (var tweet in followeeTweets)
                        {
                            if (i >= maxTweets) break;
                            q.Enqueue(tweet.tweetId,tweet.count);
                            i++;
                        }
                    }

                    i = 0;
                    while (q.Count > 0 && i < _newsFeedSize)
                    {
                        newsList.Add(q.Dequeue());
                        i++;
                    }
                }
                else
                {
                    User user = new User(userId);
                    _users.Add(userId, user);
                    _users[userId].Followees.Add(userId);
                }

                return newsList;
            }

            public void Follow(int followerId, int followeeId)
            {

                if (followerId != followeeId)
                {
                    if (!_users.ContainsKey(followerId))
                    {
                        User user = new User(followerId);
                        _users.Add(followerId, user);
                        _users[followerId].Followees.Add(followerId);

                    }

                    if (!_users.ContainsKey(followeeId))
                    {
                        User user = new User(followeeId);
                        _users.Add(followeeId, user);
                        _users[followeeId].Followees.Add(followeeId);
                    }

                    _users[followerId].Followees.Add(followeeId);
                }
            }

            public void Unfollow(int followerId, int followeeId)
            {

                if (followerId != followeeId)
                {
                    if (_users.ContainsKey(followerId))
                    {
                        _users[followerId].Followees.Remove(followeeId);
                    }

                }
            }
        }