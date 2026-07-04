public class Solution
{
   private Dictionary<int, List<int>> preMap = new Dictionary<int, List<int>>();
   private List<int> path = new List<int>();
   private HashSet<int> visited = new HashSet<int>();
   public int[] FindOrder(int numCourses, int[][] prerequisites)
   {
      for (int i = 0; i < numCourses; i++)
      {
         preMap[i] = new List<int>();
      }
      foreach (var pre in prerequisites)
      {
         preMap[pre[0]].Add(pre[1]);
      }
      for (int c = 0; c < numCourses; c++)
      {
         if (!Dfs(c)) return [];
      }
      return path.ToArray();
   }

   public bool Dfs(int course)
   {
      if (visited.Contains(course)) return false;
      visited.Add(course);
      
      foreach (int pre in preMap[course])
      {
         if (!Dfs(pre))
         {
            return false;
         }
      }
      visited.Remove(course);
      if (!path.Contains(course))
        path.Add(course);
      preMap[course].Clear();
      return true;

   }
} 
