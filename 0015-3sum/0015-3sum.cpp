class Solution {
public:
    vector<vector<int>> threeSum(vector<int>& nums) {
        sort(nums.begin(), nums.end());
        vector<vector<int>> out;
        for(int i = 0; i < nums.size(); i++)
        {
            if (nums[i] > 0) break; // avoid useless work
            if (i > 0 && nums[i] == nums[i - 1]) continue; // remove pairs
            for(int l = i + 1, r = nums.size() - 1; l < r;)
            {
                int sum = nums[i] + nums[l] + nums[r];
                if (sum > 0)
                    r--;
                else if (sum < 0)
                    l++;
                else 
                {
                    out.push_back({nums[i], nums[l], nums[r]});
                    l++;
                    r--;
                    while( l < r and (nums[l] == nums[l - 1]))
                    {
                        l++;
                    }
                }
            }
        }
        return out;
    }
};