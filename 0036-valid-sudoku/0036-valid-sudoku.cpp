class Solution {
public:
    bool isValidSudoku(vector<vector<char>>& board) {
        vector<unordered_set<char>> rows(9), cols(9), boxs(9);
        for(int y = 0; y < 9; y++)
        {
            vector<char> row = board[y];
            for(int x = 0; x < 9; x++)
            {   
                char chr = row[x];
                if( chr != '.')
                {
                    if(rows[x].count(chr) == 0)
                        rows[x].insert(chr);
                    else
                        return false;
                    if(cols[y].count(chr) == 0)
                        cols[y].insert(chr);
                    else
                        return false;
                    int indx = (y / 3) * 3 + x / 3;
                    if(boxs[indx].count(chr) == 0)
                        boxs[indx].insert(chr);
                    else
                        return false;
                }
            }
        }
        return true;
    }
};