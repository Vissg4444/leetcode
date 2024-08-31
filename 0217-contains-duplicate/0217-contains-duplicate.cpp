class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
        map<int, int> dict;
        for(int i : nums)
        {
            dict[i]++;
            if (dict[i] > 1)
                return true;
        }
        
        return false;
        
    }
};