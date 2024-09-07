class Solution {
public:
    int duplicateNumbersXOR(vector<int>& nums) {
        int result = 0;
        map <int, int> m;
        for(int i : nums)
        {
            m[i]++;
        }
        for(int i : nums)
        {
            if (m[i] == 2)
                {
                    result ^= i;
                    m.erase(i);
                }
        }
        return result;
    }
};