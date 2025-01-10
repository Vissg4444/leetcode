class Solution {
public:
    int trap(vector<int>& height) { // O(1) memory solution
    int out = 0;
    if (!height.size())
        return 0;
    for(int L = 0, R = height.size() - 1, maxL = height[L], maxR = height[R], sum = 0;L < R;)
    {
        if(maxL < maxR)
        {
            L++;
            maxL = max(maxL, height[L]);
            sum = min(maxL,maxR) - height[L];
        }
        else
        {
            R--;
            maxR = max(maxR, height[R]);
            sum = min(maxL,maxR) - height[R];
        }
        if( sum > 0)
            out += sum;
    }
    return out;
    }
};