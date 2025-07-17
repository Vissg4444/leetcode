public class Solution {
    public int Trap(int[] height) {
        int len = height.Length;
        int[] prefix = new int[len];
        int[] postfix = new int[len];
        prefix[0] = 0;
        prefix[^1] = 0;

        for(int i = 1; i < len; i++)
            prefix[i] = Math.Max(prefix[i - 1], height[i - 1]);
        for(int i = 2; i < len; i++)
            postfix[^i] = Math.Max(postfix[^(i - 1)], height[^(i - 1)]);
        
        int result = 0;

        for (int i = 1; i < len; i++)
            result += Math.Max(0, Math.Min(prefix[i],postfix[i]) - height[i]);
        return result;
    }
}
