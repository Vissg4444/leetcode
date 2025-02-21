class Solution {
public:
    int minEatingSpeed(vector<int>& piles, int h) {
        int l = 1, r = *max_element(piles.begin(), piles.end()), min_rate = r;
        while (l <= r)
        {
            int k = l + (r - l) / 2;
            long long totalTime = 0;
            for (int p : piles) 
                totalTime += ceil(static_cast<double>(p) / k);
            if (totalTime <= h) 
            {
                min_rate = k;
                r = k - 1;
            } 
            else
                l = k + 1;

        }
        return min_rate;
        
    }
};
