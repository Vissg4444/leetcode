class Solution {
public:
    int rangeSum(vector<int>& nums, int n, int left, int right) {
        left -= 1;
        right -= 1;
        long sum = 0;
        vector<int> subarray;
        for (int i = 0; i < n; i++) {
            int one = nums[i];
            subarray.push_back(one);
            for (int j = i + 1; j < n; j++) {
                subarray.push_back(subarray.back() + nums[j]);
            }
        }
        sort(subarray.begin(), subarray.end());
        const int mod = 1e9 + 7;
        for (; left <= right; left++) {
            sum = (sum + subarray[left]) % (mod);
        }
        return sum;
    }
};