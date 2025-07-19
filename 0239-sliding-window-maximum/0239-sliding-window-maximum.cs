public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        List<int> res = new List<int>();
        var pq = new PriorityQueue<(int val, int indx), int>();

        for (int r = 0; r < nums.Length; r++)
        {
            pq.Enqueue((nums[r], r), -nums[r]);
            if ( r >= k - 1)
            {
                
                while (pq.Peek().indx <= r - k)
                    pq.Dequeue();
                res.Add(pq.Peek().val);
            }

        }
        return res.ToArray();
    }
}
