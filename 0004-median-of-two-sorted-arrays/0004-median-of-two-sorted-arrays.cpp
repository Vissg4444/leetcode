class Solution {
public:
    double findMedianSortedArrays(vector<int>& nums1, vector<int>& nums2) {
        vector<int>& A = nums1;
        vector<int>& B = nums2;
        int total = A.size() + B.size();
        int half = (total + 1) / 2;

        if (B.size() < A.size()) 
            swap(A, B);

        int l = 0, r = A.size();
        while ( l <= r )
        {
            int A_part = ( l + r ) / 2;
            int B_part = half - A_part;

            // out of bounds checks for comparison
            int Aleft = A_part > 0 ? A[A_part - 1] : INT_MIN;
            int Aright = A_part < A.size() ? A[A_part] : INT_MAX;
            int Bleft = B_part > 0 ? B[B_part - 1] : INT_MIN;
            int Bright = B_part < B.size() ? B[B_part] : INT_MAX;

            if (Aleft <= Bright and Bleft <= Aright)
            {
                if (total % 2 != 0)
                    return max(Aleft,Bleft);
                else
                    return (max(Aleft,Bleft) + min(Aright,Bright)) / 2.0;
            }
            else if (Aleft > Bright)
                r = A_part - 1;
            else
                l = A_part + 1;
        }

        return -1; 
    }
};
