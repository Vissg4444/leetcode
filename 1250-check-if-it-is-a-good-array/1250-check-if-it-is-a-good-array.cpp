class Solution {
public:
    bool isGoodArray(vector<int>& nums) {
        int prev = nums[0];
        for (int n : nums)
            prev = __gcd(prev, n);
        return prev == 1;
    }

};