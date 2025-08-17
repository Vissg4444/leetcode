public class Solution {
    public int LeastInterval(char[] tasks, int n)
    {
        var pq = new PriorityQueue<int, int>(); 

        var hash = new Dictionary<char, int>(); // letter, count

        var queue = new Queue<(int count, int timeout)>();
        foreach (char task in tasks)
        {
            hash.TryGetValue(task, out int value); // if exists + 1
            hash[task] = value + 1;

        }

        foreach (int val in hash.Values)
        {
            pq.Enqueue(val, -val); // maxheap
        }

        int time = 0;
        while (pq.Count > 0 || queue.Count > 0)
        {
            time++;

            if (pq.Count > 0)
            {
                int val = pq.Dequeue();
                val--;
                if (val > 0)
                    queue.Enqueue((val, time + n));
            }
            if (queue.Count > 0 && queue.Peek().timeout == time)
            {
                int val = queue.Dequeue().count;
                pq.Enqueue(val, -val);
            }
        }
        return time;

    }
}