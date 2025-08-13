public class KthLargest
{

    PriorityQueue<int, int> minheap;
    int k;
    public KthLargest(int k, int[] nums)
    {
        minheap = new PriorityQueue<int, int>();
        this.k = k;
        foreach (int num in nums)
        {
            Add(num);
        }
    }

    public int Add(int val)
    {
        minheap.Enqueue(val, val);
        while (minheap.Count > k)
        {
            minheap.Dequeue();
        }
        return minheap.Peek();
    }
}
