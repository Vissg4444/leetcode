class Solution {
public:
    int getLucky(string s, int k) 
    {
        string num = "";
        for ( char i : s)
        {
            num += i - 'a' + 1;
        }
        for(; k > 0; k--)
        {
            int temp_sum = 0;
            for ( char i : num)
            {
                temp_sum += i - '0';
            }
            num = sum;
        }
        return num;
    }
};