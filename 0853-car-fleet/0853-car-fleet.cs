public class Solution {
    public int CarFleet(int target, int[] position, int[] speed)
    {

        var pair = new List<(int pos, int spd)>();
        for (int i = 0; i < position.Length; i++)
            pair.Add((position[i], speed[i]));

        pair.Sort((i1, i2) => i2.CompareTo(i1));
        var stack = new Stack<double>();
        foreach (var p in pair)
        {
            int pos = p.pos;
            int spd = p.spd;
            double moves = ((double)(target - pos) / spd);
            stack.Push(moves);
            while (stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1))
            {
                stack.Pop();
            }
            
        }

        return stack.Count;
    }
}
