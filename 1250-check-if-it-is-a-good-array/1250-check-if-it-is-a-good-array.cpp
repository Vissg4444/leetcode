class Solution {
public:
    bool isGoodArray(vector<int>& nums) {
        int prev = nums[0];
        for ( int i = 0; i < nums.size(); i++ )
        {
            prev = extended_gcd(prev, nums[i])[0];
        }
        if ( prev == 1 )
            return 1;
        else
            return 0;
    }
    vector<int> extended_gcd(int a, int b)
    {
        pair<int, int> r = { a, b }, x = { 1, 0 }, y = { 0, 1 };
        while ( r.second > 0 )
        {
            int q = r.first / r.second;
            r = { r.second, r.first - q * r.second };
            x = { x.second, x.first - q * x.second };
            y = { y.second, y.first - q * y.second };
        }
        return { r.first, x.first, y.first };
    }
};