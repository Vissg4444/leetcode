class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
        map<int, int> dict;
        for(int i = 0; i < size(nums); i++)
        {
            if (dict.count(nums[i]) != 0) return true;
            dict[nums[i]]++;
        }
        
        return false;
        
    }
};