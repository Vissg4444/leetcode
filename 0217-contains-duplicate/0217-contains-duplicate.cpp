class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
        map<int, int> dict;
        for(int i = 0; i < size(nums); i++)
        {
            dict[nums[i]]++;
            if (dict[nums[i]] > 1)
                return true;
        }
        
        return false;
        
    }
};