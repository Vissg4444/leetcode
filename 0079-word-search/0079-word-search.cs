public class Solution {
    public bool Exist(char[][] board, string word)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == word[0])
                {
                    if (Iterate(board, word, new bool[board.Length, board[0].Length], i, j, 0))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    public bool Iterate(char[][] board, string word, bool[,] visited, int i, int j, int k)
    {
        if (k == word.Length) return true;
        if (i < 0 || i >= board.Length || j < 0 || j >=
         board[0].Length || board[i][j] != word[k]) return false;
        if (visited[i, j]) return false;
        if (board[i][j] == word[k])
        {
            visited[i, j] = true;
            bool left = Iterate(board, word, visited, i - 1, j, k + 1);
            bool right = Iterate(board, word, visited, i + 1, j, k + 1);
            bool top = Iterate(board, word, visited, i, j + 1, k + 1);
            bool down = Iterate(board, word, visited, i, j - 1, k + 1);
            visited[i, j] = false;
            return left || right || top || down;
        }
        else return false;
    }
}
