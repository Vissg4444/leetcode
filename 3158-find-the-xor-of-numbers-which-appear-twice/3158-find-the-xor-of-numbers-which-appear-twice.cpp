class Solution {
public:
    int duplicateNumbersXOR(vector<int>& nums) {
        int result = 0;
        vector<char> v(51, 0);
        for(char num : nums)
        {
            v[num]++;
            if(v[num] == 2)
            {
                result ^= num;
            }
        }
        return result;
    }
};