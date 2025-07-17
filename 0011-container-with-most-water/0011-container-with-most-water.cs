public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0, r = heights.Length - 1;
        int maxArea = 0;
        while (l < r)
        {
            int water_stored = Math.Min(heights[l],heights[r]) * (r - l);
            maxArea = Math.Max(water_stored, maxArea);
            if (heights[l] < heights[r])
                l++;
            else
                r--;
        }
        return maxArea;
    }
}
