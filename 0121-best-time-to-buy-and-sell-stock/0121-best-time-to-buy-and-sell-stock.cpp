class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int L = 0, R = 1, profit = 0;
        while( R < prices.size())
        {
            if( prices[L] < prices[R])
                profit = max(profit, prices[R] - prices[L]);
            else
                L = R;
            R++;
        }
        return profit;   
    }
};