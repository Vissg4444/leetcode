public class MedianFinder {

    PriorityQueue<int, int> minHeap;
    PriorityQueue<int, int> maxHeap;
    public MedianFinder()
    {
        minHeap = new PriorityQueue<int, int>();
        maxHeap = new PriorityQueue<int, int>();
    }

    public void AddNum(int num)
    {
        if (maxHeap.Count > 0 && num > maxHeap.Peek())
            maxHeap.Enqueue(num, num);
        else
            minHeap.Enqueue(num, -num);

        if (minHeap.Count > maxHeap.Count + 1)
        {
            int elem = minHeap.Dequeue();
            maxHeap.Enqueue(elem, elem);
        }
        else if (maxHeap.Count > minHeap.Count + 1)
        {
            int elem = maxHeap.Dequeue();
            minHeap.Enqueue(elem, -elem);
        }


    }

    public double FindMedian()
    {
        if (maxHeap.Count > minHeap.Count)
        {
            return maxHeap.Peek();
        }
        else if (minHeap.Count > maxHeap.Count)
        {
            return minHeap.Peek();
        }
        else return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
    }
}
