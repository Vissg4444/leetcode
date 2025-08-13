public class Solution {
    public int[][] KClosest(int[][] points, int k)
    {
        var pq = new PriorityQueue<int[], double>();

        foreach (var p in points)
        {
            double x = p[0];
            double y = p[1];
            double dist = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            pq.Enqueue(p, dist); // minheap
        }

        int[][] result = new int[k][];
        for (int i = 0; i < k; i++)
        {
            result[i] = pq.Dequeue();
        }

        return result;
    }
}
