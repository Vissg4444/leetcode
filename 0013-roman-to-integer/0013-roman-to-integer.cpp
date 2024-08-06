
class Solution {
public:
    int romanToInt(string s) {
        map<char,int> dict;
        int sum = 0;
        char temp = ' ';
        dict.insert(pair<char, int>('I', 1));
        dict.insert(pair<char, int>('V', 5));
        dict.insert(pair<char, int>('X', 10));
        dict.insert(pair<char, int>('L', 50));
        dict.insert(pair<char, int>('C', 100));
        dict.insert(pair<char, int>('D', 500));
        dict.insert(pair<char, int>('M', 1000));
        for(char charik : s)
        {  
            cout << temp << ' ' << charik << ' ';
            if (dict[temp] < dict[charik])
                sum -= 2*dict[temp];
            sum += dict[charik];
            temp = charik;
            cout << sum << ' ' << endl;
        }
        return sum;
    }
};