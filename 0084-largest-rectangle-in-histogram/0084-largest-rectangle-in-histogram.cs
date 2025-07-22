public class Solution {
    public int LargestRectangleArea(int[] heights)
    {
        var stack = new Stack<(int indx, int heigth)>();
        int max_area = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            if( stack.Count() > 0)
            {
                int top_height = stack.Peek().heigth;
                int top_indx = stack.Peek().indx;
                int min_indx = -1;
                while (stack.Count() > 0 && top_height > heights[i])
                {
                    max_area = Math.Max(max_area, (i - top_indx) * top_height);
                    stack.Pop();
                    min_indx = top_indx;

                    stack.TryPeek(out (int indx,int heigth) pair);
                    top_height = pair.heigth;
                    top_indx = pair.indx;
                }
                if (min_indx != -1)
                    stack.Push((min_indx, heights[i]));
                else
                    stack.Push((i, heights[i]));
            }
            else
            {
                stack.Push((i, heights[i]));
            }
        }
        while (stack.Count() > 0)
        {
            int top_height = stack.Peek().heigth;
            int top_indx = stack.Peek().indx;
            max_area = Math.Max(max_area, (heights.Length - top_indx) * top_height);
            stack.Pop();
        }
        return max_area;
    }
}
