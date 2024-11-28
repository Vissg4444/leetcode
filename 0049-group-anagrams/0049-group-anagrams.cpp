class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        vector < vector < string >> out;
        map < map < char, int > , vector < string >> dict; //key - value
        for (string str: strs) {
            map < char, int > m;
            for (int i = 0; i < str.size(); i++) {
                m[str[i]]++;
            }
            dict[m].push_back(str);
        }
        for (auto x: dict) {
            out.push_back(x.second);
        }
        return out;
    }
};
