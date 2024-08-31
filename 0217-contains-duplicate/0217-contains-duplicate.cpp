class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
        sort(nums.begin(), nums.end());
        map<int, char> dict;
        for(int i : nums)
        {
            dict[i] ++;
            if (dict[i] > 1)
                return true;
        }
        
        return false;
        
    }
};