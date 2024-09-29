class Solution {
public:
    vector<int> getSneakyNumbers(vector<int>& nums) {
        map<int, char> d;
        vector<int> out;
        for(char num : nums)
        {
            d[num]++;
            if (d[num] == 2)
                out.push_back(num);
        }
        return out;
    }
};