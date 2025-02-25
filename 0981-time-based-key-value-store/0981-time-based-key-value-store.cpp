class TimeMap {
public:
    TimeMap() {}
    map<string, vector<pair<int, string>>> hash;
    void set(string key, string value, int timestamp) {
        //append in hashmap
        pair<int, string> temp = {timestamp, value};
        hash[key].push_back(temp);
    }
    
    string get(string key, int timestamp) {
        //binary search
        auto &vec = hash[key];
        pair<int, string> m_recent{0,""};
        int l = 0, r = vec.size() - 1;
        while ( l <= r)
        {
            int mid = l + ( r - l ) / 2;
            pair<int, string> found = vec[mid];
            if (found.first <= timestamp) 
            {
            m_recent = found;
            l = mid + 1;
            }
            if (found.first == timestamp) return vec[mid].second;
            else if (found.first > timestamp)
                r = mid - 1;
        }

        return m_recent.second; //closest
    }
};
