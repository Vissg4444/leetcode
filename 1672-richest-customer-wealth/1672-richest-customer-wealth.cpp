class Solution {
public:
    int maximumWealth(vector<vector<int>>& accounts) 
    {
        int wealth = 0, temp = 0;
        for(int i = 0; i < accounts.size(); i++)
        {
            for(int j = 0; j < accounts[i].size(); j++)
            {
                temp += accounts[i][j];
            }
            wealth = temp > wealth ? temp : wealth;
            temp = 0;
        }
        return wealth;
    }
};