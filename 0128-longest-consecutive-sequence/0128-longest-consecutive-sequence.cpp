class Solution {
public:
        int longestConsecutive(vector<int>& nums) {
        unordered_set<int> set (nums.begin(), nums.end());
        int max_len = 0, len = 0;
        for(int num : set)
        {
            if(set.count(num - 1) == 0) // does not exist
            {
                for(int cur_num = num; set.count(cur_num) != 0; cur_num++)
                {
                    len++;
                }
                max_len = max(max_len, len);
                len = 0;
            }
        }
        return max_len;
    }
};