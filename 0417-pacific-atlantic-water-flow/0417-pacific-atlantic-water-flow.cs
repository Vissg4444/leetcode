public class Solution
{

   private static int[][] dirs = new int[][]
   {
        new int[] { -1, 0 },
        new int[] {  1, 0 },
        new int[] {  0, -1 },
        new int[] {  0, 1 }
   };

   private List<IList<int>> res = new List<IList<int>>();

   public IList<IList<int>> PacificAtlantic(int[][] heights)
   {
      int m = heights.Length;       
      int n = heights[0].Length;    


      for (int i = 0; i < m; i++)
      {
         for (int j = 0; j < n; j++)
         {
            BFS(i, j, heights, m, n);
         }
      }
      return res;
   }


   private void BFS(int startRow, int startCol, int[][] heights, int m, int n)
   {
      Queue<(int, int)> queue = new Queue<(int, int)>();
      HashSet<(int, int)> visited = new HashSet<(int, int)>();

      queue.Enqueue((startRow, startCol));
      visited.Add((startRow, startCol));

      bool pacific = false;
      bool atlantic = false;

      while (queue.Count > 0)
      {
         var (r, c) = queue.Dequeue();

         foreach (var dir in dirs)
         {
            int nr = r + dir[0];
            int nc = c + dir[1];

            if (nr < 0 || nc < 0)
            {

               pacific = true;
            }
            else if (nr >= m || nc >= n)
            {
               atlantic = true;
            }
            else
            {

               if (heights[nr][nc] <= heights[r][c] && !visited.Contains((nr, nc)))
               {
                  visited.Add((nr, nc));
                  queue.Enqueue((nr, nc));
               }
            }

            if (pacific && atlantic)
            {
               res.Add(new List<int> { startRow, startCol });
               return;
            }
         }
      }
   }
}