class Solution {
public:
    bool containsNearbyDuplicate(vector<int>& nums, int k) {
        unordered_map<int, int> dict;
        for (int i = 0; i < size(nums); i++) {
            if (dict.contains(nums[i])) {
                {
                    if (i - dict[nums[i]] <= k)
                        return true;
                }
            }
            dict[nums[i]] = i;
        }
        return false;
    }
};