class Solution {
public:
    bool isPalindrome(string s) {
        int l = 0, r = s.length() - 1;
        for(; l < r; l++, r--)
        {
            while(l < r and !isalnum(s[l]))
                l++;
            while(r > l and !isalnum(s[r]))
                r--;  
            if(char(tolower(s[l])) != char(tolower(s[r])))
                return false;
        }
        return true;
    }
};