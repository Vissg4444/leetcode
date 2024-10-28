class Solution {
public:
    int minimumDifference(vector<int>& nums, int k) {
        int diff = 10000000;
        sort(nums.begin(),nums.end());
        
        for(int l = 0, r = k - 1; r < size(nums); l++, r++)
        {
            diff = min(diff, nums[r] - nums[l]);
        }
        return diff;
    }

};