public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int cols = matrix[0].Length - 1, rows = matrix.Length - 1;

        int l = 0, r = rows;
        int mid = 0;
        while (l <= r)
        {
            mid = l + (r - l) / 2;
            if (target > matrix[mid][cols])
                l = mid + 1;
            else if (target < matrix[mid][0])
             r = mid - 1;
            else break;
        }
        int row = mid;
        l = 0;
        r = cols;
        while (l <= r)
        {
            mid = l + (r - l) / 2;
            if (target > matrix[row][mid])
                l = mid + 1;
            else if (target < matrix[row][mid])
                r = mid - 1;
            else if (target == matrix[row][mid])
                return true;
        }
        return false;
    }
}
