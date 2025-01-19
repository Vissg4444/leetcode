class Solution {
public:
    string minWindow(string s, string t) {
        if (t == "") return "";

        unordered_map<char,int> window, T;
        for (char c : t)
        {
            T[c]++;
        }

        int have = 0, need = T.size(), out_len = INT_MAX;
        pair<int,int> out = {-1,-1};

        for(int l = 0, r = 0; r < s.size(); r++)
        {
            window[s[r]]++;
             if(T.count(s[r]) and window[s[r]] == T[s[r]])
                have++;
             while(have == need)
             {
                if( r - l + 1 < out_len)
                {
                    out_len = r - l + 1;
                    out = {l, r};
                }
                
                window[s[l]]--;
                if(T.count(s[l]) and window[s[l]] < T[s[l]]) {
                    have--;
                }
                l++;  
             }
       
        }
        return out_len == INT_MAX ? "" : s.substr(out.first,out_len);
    }
};