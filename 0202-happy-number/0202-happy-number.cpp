class Solution {
public:
    bool isHappy(int n) {
        set <int> s;
        int temp = 0;
        while(true)
        {
            if (s.contains(n))
                return false;
            s.insert(n);
            while(n != 0)
            {
                temp += pow(n % 10,2);
                n /= 10;
            }
            if (temp == 1)
                return true;
            n = temp;
            temp = 0;
        }

    }
};