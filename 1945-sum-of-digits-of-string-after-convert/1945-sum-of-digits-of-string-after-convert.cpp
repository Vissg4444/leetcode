class Solution {
public:
    int getLucky(string s, int k) {
        int sum = 0, num;
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        if (k)
        {
            for (char i : s) 
            {
                if (alphabet.find(i) != std::string::npos)
                    num = (int)i - 96;
                else
                    num = int(i) - '0';
                while (num != 0) 
                {
                    sum += num % 10;
                    num /= 10;
                }
            }
            return getLucky(to_string(sum), k-1);
        }
        else
            return stoi(s);
    }
};