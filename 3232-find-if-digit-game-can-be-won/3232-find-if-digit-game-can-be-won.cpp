class Solution {
public:
    bool canAliceWin(vector<int>& nums) {
        int single = 0, doubl = 0;
        for(int num : nums)
        {
            if (num < 10)
                {
                    single -= num;
                    doubl += num;
                }
            else
                {
                    single += num;
                    doubl -= num;
                }
        }
        return single > 0 or doubl > 0;
    }
};