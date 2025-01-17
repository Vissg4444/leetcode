class Solution {
public:
    int characterReplacement(string s, int k) {
        int out = 0, l = 0, maxf = 0;
        map<char, int> hash;
        for(int r = 0; r < s.size(); r++)
        {
            hash[s[r]]++;
            maxf = max(maxf, hash[s[r]]);

            while((r - l + 1) - maxf > k)
            {
                hash[s[l]]--;
                l++;
            }
            out = max(out, r - l + 1);
        }
        return out;
    }
};