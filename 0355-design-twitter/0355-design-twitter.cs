public class Twitter {
    private int count;
    private Dictionary<int, List<int[]>> TweetMap;
    private Dictionary<int, HashSet<int>> FolowMap;
    public Twitter()
    {
        count = 0;
        TweetMap = new Dictionary<int, List<int[]>>();
        FolowMap = new Dictionary<int, HashSet<int>>();
    }

    public void PostTweet(int userId, int tweetId)
    {
        if (!TweetMap.ContainsKey(userId))
        {
            TweetMap[userId] = new List<int[]>();
        }
        TweetMap[userId].Add(new int[] { count++, tweetId });
    }

    public List<int> GetNewsFeed(int userId)
    {
        List<int> res = new List<int>();
        PriorityQueue<int[], int> minHeap = new PriorityQueue<int[], int>();

        if (!FolowMap.ContainsKey(userId))
        {
            FolowMap[userId] = new HashSet<int>();
        }
        FolowMap[userId].Add(userId);

        foreach (int foloweeId in FolowMap[userId])
        {
            if (TweetMap.ContainsKey(foloweeId) && TweetMap[foloweeId].Count > 0)
            {
                List<int[]> tweets = TweetMap[foloweeId];
                int index = tweets.Count - 1; // last one
                int[] latestTweet = tweets[index]; // [0] - count, [1] - tweetid
                minHeap.Enqueue(new int[] { latestTweet[0], latestTweet[1], foloweeId, index }, -latestTweet[0]);
            }
        }

        while (minHeap.Count > 0 && res.Count < 10)
        {
            int[] curr = minHeap.Dequeue();
            // curr[1] - tweetid, curr[2] - foloweeId, curr[3] - index
            res.Add(curr[1]);
            int index = curr[3];
            if (index > 0)
            {
                int[] tweet = TweetMap[curr[2]][index - 1];
                minHeap.Enqueue(new int[] { tweet[0], tweet[1], curr[2], index - 1 }, -tweet[0]);
            }
        }

        return res;
        
    }

    public void Follow(int followerId, int followeeId)
    {
        if (!FolowMap.ContainsKey(followerId))
        {
            FolowMap[followerId] = new HashSet<int>();
        }
        FolowMap[followerId].Add(followeeId);
    }

    public void Unfollow(int followerId, int followeeId)
    {
        if(FolowMap.ContainsKey(followerId))
        {
            FolowMap[followerId].Remove(followeeId);
        }
    }
}
