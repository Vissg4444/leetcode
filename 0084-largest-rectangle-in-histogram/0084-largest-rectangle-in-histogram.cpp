class Solution {
public:
    int largestRectangleArea(vector<int>& heights) {
        int max_rectangle = 0;
        stack<pair<int,int>> stk;
        for(int i = 0; i < heights.size(); i++)
        {
            int index = i;
            while(!stk.empty() and stk.top().second > heights[i])
            {
                pair<int,int> p = stk.top();
                index = p.first;
                max_rectangle = max(max_rectangle, p.second * (i - p.first));
                stk.pop();
            }
            stk.push({index,heights[i]});
        }
        while(!stk.empty())
        {
            pair<int,int> p = stk.top();
            max_rectangle = max(max_rectangle, p.second * (static_cast<int>(heights.size()) - p.first));
            stk.pop();
        }
        return max_rectangle;
    }
};
