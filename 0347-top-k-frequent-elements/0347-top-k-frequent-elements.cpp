class Solution {
public:
    static bool compare(pair<int, int> p1, pair<int, int> p2)
    {
        if (p1.second == p2.second)
            return p1.first > p2.first;
        return p1.second > p2.second;
    };
    vector<int> topKFrequent(vector<int>& nums, int k) 
    {
        vector<int> out;
        unordered_map<int, int> m;
        for(int num : nums)
        {
            m[num]++;
        }

        vector<pair<int, int>> freq(m.begin(), m.end());
        
        sort(freq.begin(), freq.end(), compare);

        for(int i = 0; i < k; i++)
        {
            out.push_back(freq[i].first);
        }
        return out;
    }
};
