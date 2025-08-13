public class Solution {
    public int LastStoneWeight(int[] stones)
    {
        var pq = new PriorityQueue<int, int>();

        foreach (int stone in stones)
        {
            pq.Enqueue(stone, -stone); //maxheap
        }

        while (pq.Count > 1)
        {
            int x = pq.Dequeue();
            int y = pq.Dequeue();
            int diff = Math.Abs(x - y);
            if (diff > 0) pq.Enqueue(diff, -diff);
        }

        return pq.Count > 0 ? pq.Peek() : 0; 
    }
}
