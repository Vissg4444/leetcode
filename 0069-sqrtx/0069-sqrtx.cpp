class Solution {
public:
    int mySqrt(int x) 
    {   
        long long L = 0, R = x;
        while (L <= R)
        {
            long long M = (L + R) / 2;
            long long M_squa = M * M;
            if ((M_squa) == x)
                return M;
            else if (M_squa > x)
                R = M - 1;
            else
                L = M + 1;
        }
        return R;
    }
};