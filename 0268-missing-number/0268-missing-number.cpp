class Solution {
public:
    int missingNumber(vector<int>& nums) 
    {
        int result = 0;
        for(int i = 0; i < size(nums); i++)
        {
            result ^= i;
            result ^= nums[i];
        }
        result ^= size(nums);
        return result;
    }
};