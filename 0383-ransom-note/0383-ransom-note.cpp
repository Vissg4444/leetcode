class Solution {
public:
    bool canConstruct(string ransomNote, string magazine) 
    {
        int count[26] = {};
        for( char symbol : magazine)
            ++count[symbol - 'a'];
        for (char symbol : ransomNote)
            if (--count[symbol - 'a'] < 0)
                return false;
        return true;
    }
};