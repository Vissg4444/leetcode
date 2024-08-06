class Solution {
public:
    bool isPalindrome(int x) {
        if (x < 0)
            return false;
        long long reversed = 0, temp = x;
        while (temp != 0)
        {
            char i = temp % 10;
            reversed = reversed * 10 + i;
            temp /= 10;
        }
        return (x == reversed);
    }
};