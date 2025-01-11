class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        int out = 0, l;
        unordered_set<char> charSet;
        for(int r = 0; r < s.size(); r++)
        {
            while ( charSet.find(s[r]) != charSet.end())
            {
                charSet.erase(s[l]);
                l++;
            }
            charSet.insert(s[r]);
            out = max(out, r - l + 1);
        }
        return out;
    }
};