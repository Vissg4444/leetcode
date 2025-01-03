class Solution {
public:
    int trap(vector<int>& height) { // O(n) memory solution
        int len = height.size(), out = 0;
        if (len == 0)
            return 0;
        vector<int> maxL(len,0), maxR(len,0);
        for(int i = 1, maximum = 0; i < len; i++)
        {
            maximum = max(maximum, height[i - 1]);
            maxL[i] = maximum;
        }
        for(int i = len - 2, maximum = 0; i >= 0; i--)
        {
            maximum = max(maximum, height[i + 1]);
            maxR[i] = maximum;
        }
        for(int i = 0; i < len; i++)
        {
            int sum = min(maxL[i],maxR[i]) - height[i];
            if (sum > 0)
                out += sum;
        }
        return out;
    }
};