public class Solution {
    private Dictionary<int, List<int>> preMap = new Dictionary<int, List<int>>();
    private HashSet<int> visiting = new HashSet<int>();

    public bool CanFinish(int numCourses, int[][] prerequisites) {
        for (int i = 0; i < numCourses; i++)
        {
            preMap[i] = new List<int>();
        }
        foreach (var preq in prerequisites) {
            preMap[preq[0]].Add(preq[1]);
        }
        for (int c = 0; c < numCourses; c++)
        {
            if (!Dfs(c)) {
                return false;
            }
        }
        return true;
    }

    public bool Dfs(int c)
    {
        if (visiting.Contains(c))
        {
            return false;
        }
        if (preMap[c].Count == 0)
        {
            return true;
        }
        visiting.Add(c);
        foreach (int pre in preMap[c])
        {
            if (!Dfs(pre))
            {
                return false;
            }
        }
        visiting.Remove(c);
        preMap[c].Clear();
        return true;
    }
}
