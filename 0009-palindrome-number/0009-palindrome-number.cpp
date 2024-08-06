class Solution {
public:
    bool isPalindrome(int x) {
        vector<int> v;
        if (x < 0)
            return false;
        while (x != 0) {
            v.push_back(x % 10);
            x /= 10;
        }
        vector<int> a = v;
        reverse(v.begin(), v.end());
        if (equal(v.begin(), v.end(), a.begin()))
            return true;
        return false;
    }
};