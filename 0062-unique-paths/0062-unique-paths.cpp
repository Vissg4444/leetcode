class Solution {
public:
    int uniquePaths(int m, int n) 
    {
        vector<vector<int>> out(m, vector<int>(n));
        for (int i = 0; i < n; i++)
        {
            out[0][i] = 1;
        }
        for (int i = 0; i < m; i++)
        {
            out[i][0] = 1;
        }
        for(int i = 1; i < m; i++ )
        {
            for(int j = 1; j < n; j++)
            {
                out[i][j] = out[i - 1][j] + out[i][j - 1];
            }
        }
        return out[m - 1][n - 1];
    }
};