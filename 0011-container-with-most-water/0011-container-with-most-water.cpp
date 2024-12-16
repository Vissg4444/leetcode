class Solution {
public:
    int maxArea(vector<int>& height) {
        int max_area = 0;
        for(int l = 0, r = height.size() - 1; l < r;)
        {
            max_area = max(max_area, ( (r - l) * min(height[l], height[r])));
            height[l] < height[r] ? l++ : r--;
        }
        return max_area;
    }
};