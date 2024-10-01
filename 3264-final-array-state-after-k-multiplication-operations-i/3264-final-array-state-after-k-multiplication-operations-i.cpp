class Solution {
public:
    vector<int> getFinalState(vector<int>& nums, int k, int multiplier) 
    {
        priority_queue<pair<int, int>, vector<pair<int, int>>, greater<pair<int, int>>> g;
        for (int i = 0; i < size(nums); i++) 
            g.push(make_pair(nums[i], i));

        for(; k > 0; k--)
        {
            auto temp = make_pair(g.top().first * multiplier, g.top().second);
            g.pop();
            g.push(temp);
        }

        for( ; !g.empty(); g.pop())
            nums[g.top().second] = g.top().first;


        return nums;
    }
};