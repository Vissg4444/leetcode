public class Solution
{
    int[,] visited;

    public int NumIslands(char[][] grid)
    {
        if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            return 0;

        int rows = grid.Length;
        int cols = grid[0].Length;
        visited = new int[rows, cols];

        int num = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == '1' && visited[i, j] == 0)
                {
                    num++;
                    DFS(grid, i, j, num);
                }
            }
        }

        return num;
    }

    public void DFS(char[][] grid, int i, int j, int comp)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        if (i < 0 || i >= rows || j < 0 || j >= cols)
            return;

        if (grid[i][j] == '0' || visited[i, j] != 0)
            return;

        visited[i, j] = comp;

        DFS(grid, i + 1, j, comp);
        DFS(grid, i - 1, j, comp);
        DFS(grid, i, j + 1, comp);
        DFS(grid, i, j - 1, comp);
    }
}