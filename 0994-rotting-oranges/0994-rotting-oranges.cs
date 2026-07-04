public class Solution
{
    private int[][] dirs = new int[][]
    {
        new int[] { -1, 0 },
        new int[] {  1, 0 },
        new int[] {  0, -1 },
        new int[] {  0, 1 }
    };

    public int OrangesRotting(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        Queue<(int, int)> q = new Queue<(int, int)>();
        int fresh = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == 2)
                    q.Enqueue((i, j));
                else if (grid[i][j] == 1)
                    fresh++;
            }
        }


        if (fresh == 0)
            return 0;

        int minutes = 0;

        while (q.Count > 0 && fresh > 0)
        {
            int size = q.Count;

            for (int k = 0; k < size; k++)
            {
                var (i, j) = q.Dequeue();

                foreach (int[] dir in dirs)
                {
                    int ni = i + dir[0];
                    int nj = j + dir[1];

                    if (ni < 0 || ni >= rows || nj < 0 || nj >= cols)
                        continue;

                    if (grid[ni][nj] != 1)
                        continue;

                    grid[ni][nj] = 2;
                    fresh--;
                    q.Enqueue((ni, nj));
                }
            }

            minutes++;
        }

        return fresh == 0 ? minutes : -1;
    }
}