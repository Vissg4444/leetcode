class Solution {
public:
    int findDuplicate(vector<int>& nums) {
        int i = 0;
        while(1)
        {
            i = abs(nums[i]);
            if(nums[i] < 0) return i;
            nums[i] = -nums[i];

        }
    }
};
