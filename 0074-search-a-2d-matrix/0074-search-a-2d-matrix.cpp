class Solution {
public:
    bool searchMatrix(vector<vector<int>>& matrix, int target) {
        // log(m + n)
        int rows = matrix.size(), cols = matrix[0].size() - 1;
        int top = 0, bot = rows - 1;
        // top of matrix - 0, bot = size - 1 because 0-indexed arr
        while (top <= bot)
        {
            int row = top + (bot - top) / 2;
            if (target > matrix[row][cols])
                top = row + 1;
            else if (target < matrix[row][0])
                bot = row - 1;
            else break;
        }

        if (!(top <= bot)) // if row not found
            return false;

        //row found, binary search in it

        int l = 0, r = cols, row = top + (bot - top) / 2;
        while ( l <= r)
        {
            int mid = l + (r - l) / 2;
            if (target > matrix[row][mid])
                l = mid + 1;
            else if (target < matrix[row][mid])
                r = mid - 1;
            else return true;
        }
        return false;
    }
};
