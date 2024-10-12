class Solution {
public:
    vector<int> numberGame(vector<int>& nums) {
        sort(nums.begin(), nums.end());
        for(int i = 0; i < (size(nums)); i+=2)
        {
            nums[i] ^= nums[i+1];
            nums[i+1] ^= nums[i];
            nums[i] ^= nums[i+1];
        }
        return nums;
    }
};