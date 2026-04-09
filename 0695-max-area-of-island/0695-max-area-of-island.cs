using System.Runtime.CompilerServices;
public class Solution {
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public int MaxAreaOfIsland(int[][] grid) {
        int maxarea = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                
                if (grid[i][j] != 0)
                {
                    maxarea = Math.Max(maxarea, DFS(grid, i, j, 1));
                }
            }
        }
        return maxarea;
    }
    public int DFS(int[][] grid, int i, int j, int area)
    {
        if (
        i >= grid.Length 
        || i < 0 
        || j >= grid[0].Length 
        || j < 0 
        || grid[i][j] == 0
        )
        {
            return 0;
        }

        grid[i][j] = 0;
        int r = DFS(grid, i + 1, j, area + 1);
        int l = DFS(grid, i - 1, j, area + 1);
        int t = DFS(grid, i, j + 1, area + 1);
        int d = DFS(grid, i, j - 1, area + 1);
        return 1 + r + l + t + d;

    }
}
