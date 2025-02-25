class TimeMap {
public:
    TimeMap() {}
    map<string, vector<pair<int, string>>> hash;
    void set(string key, string value, int timestamp) {
        //append in hashmap
        hash[key].push_back({timestamp, value});
    }
    
    string get(string key, int timestamp) {
        //binary search
        auto &vec = hash[key];
        string out = "";
        int l = 0, r = vec.size() - 1;
        while ( l <= r)
        {
            int mid = l + ( r - l ) / 2;
            pair<int, string> found = vec[mid];
            if (found.first <= timestamp) 
            {
            out = found.second;
            l = mid + 1;
            }
            else if (found.first > timestamp)
                r = mid - 1;
        }

        return out; //closest
    }
};
