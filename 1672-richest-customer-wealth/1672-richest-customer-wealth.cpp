class Solution {
public:
    int maximumWealth(vector<vector<int>>& accounts) 
    {
        int wealth = 0;
        for(auto account : accounts)
        {
            int temp = 0;
            for(int j = 0; j < account.size(); j++)
            {
                temp += account[j];
            }
            wealth = max(temp, wealth);

        }
        return wealth;
    }
};