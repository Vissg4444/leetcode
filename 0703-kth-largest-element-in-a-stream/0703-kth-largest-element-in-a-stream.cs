public class KthLargest {
    
    private PriorityQueue<int,int> minheap = new PriorityQueue<int, int>();
    private int k;
    public KthLargest(int k, int[] nums)
    {
        this.minheap = new PriorityQueue<int, int>();
        this.k = k;
        foreach (int num in nums)
        {
            minheap.Enqueue(num, num);
            if (minheap.Count > k)
            {
                minheap.Dequeue();
            }
        }
    }

    public int Add(int val)
    {
        minheap.Enqueue(val, val);
        if (minheap.Count > k)
        {
            minheap.Dequeue();
        }
        return minheap.Peek();
    }
}
