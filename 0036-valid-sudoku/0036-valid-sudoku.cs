public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        var cols = new List<HashSet<char>>();
        var rows = new List<HashSet<char>>();
        var boxs = new List<HashSet<char>>();
        for(int i = 0; i < 9; i++)
        {
            cols.Add(new HashSet<char>());
            rows.Add(new HashSet<char>());
            boxs.Add(new HashSet<char>());
        }
        for (int x = 0; x < 9; x++)
        {

            for(int y = 0; y < 9; y++)
            {
                if (board[x][y] != '.')
                {
                    if (cols[y].Contains(board[x][y]))
                    {
                        return false;
                    }
                    if (rows[x].Contains(board[x][y]))
                    {
                        return false;
                    }
                    int index = (x / 3) + 3 * (y / 3);
                    if (boxs[index].Contains(board[x][y]))
                    {
                        return false;
                    }
                    cols[y].Add(board[x][y]);
                    rows[x].Add(board[x][y]);
                    boxs[index].Add(board[x][y]);
                }

            }
        }
        return true;
    }
}