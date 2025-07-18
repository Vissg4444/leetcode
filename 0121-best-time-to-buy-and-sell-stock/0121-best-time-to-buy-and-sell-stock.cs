public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 1, sum = 0;

        while (r < prices.Length)
        {
            if (prices[l] < prices[r])
                sum = Math.Max(sum, prices[r] - prices[l]);
            else
                l = r;
            r++;
        }
        return sum;
    }
}
